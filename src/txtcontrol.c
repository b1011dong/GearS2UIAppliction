/*
 * readfile.c
 *
 *  Created on: Oct 2, 2015
 *      Author: SON
 */
#include "s_txtform.h"
#include <stdlib.h>
#define MAX_STRING_LENGTH 100
#define RES_PATH_MAX 260
#include <stdio.h>

#define MESSAGE_PORT_FROM_UIAPP "m_port_uiapp"
#define MAX_PATH 260

/**
 * 여기 함수 사용할 때 이렇게 사용하면 됨
 *
 * txtForm *txtform;
 * mod_get_shared_folder("text.txt", file_path);
 * txtform = mod_read_file(file_path);
 *
 */

/**
 * txt 저장 형식
	(int) digit_value
	(float) total_money
	(int) 수입 카테고리 갯수
	(char*) 수입카테고리 array list
	...
	(int) 지출 카테고리 갯수
	(char*) 지출카테고리 array list
	...
 */

/**
 * 파일에서 txtForm형식으로 옮겨오는 함수
 *
 */
txtForm *mod_read_file(char *dest) {
	FILE *fp;
	char buf[100] = { 0, };				// fgets 받을 변수
	txtForm *read_data = NULL;		// return 값

	char **expend_list;
	char **income_list;

	int i;

	fp = fopen(dest, "r");
	if (!fp) {
		dlog_print(DLOG_DEBUG, "tag", "%s - %s", __func__, "File open error!");
	} else {
		read_data = (txtForm *) malloc(sizeof(txtForm));

		// Get Digit
		fgets(buf, MAX_STRING_LENGTH, fp);
		read_data->digit = atoi(buf);

		// Get total money
		fgets(buf, MAX_STRING_LENGTH, fp);
		read_data->total_money = atoi(buf);

		// Create income list
		fgets(buf, MAX_STRING_LENGTH, fp);
		read_data->income_num = atoi(buf);
		income_list = (char **) malloc(read_data->income_num * sizeof(char *));

		for (i = 0; i < read_data->income_num; i++) {
			fgets(buf, MAX_STRING_LENGTH, fp);
			income_list[i] = (char *) malloc((strlen(buf)) * sizeof(char));
			strcpy(income_list[i], buf);
			income_list[i][strlen(buf)-2]='\0';
			dlog_print(DLOG_DEBUG, "tag1", "%s - buf : %s. list : %s.", __func__, buf,income_list[i]);
		}
		read_data->income_list = income_list;

		// Create expend list
		fgets(buf, MAX_STRING_LENGTH, fp);
		read_data->expend_num = atoi(buf);
		expend_list = (char **) malloc(read_data->expend_num * sizeof(char *));

		for (i = 0; i < read_data->expend_num; i++) {
			fgets(buf, MAX_STRING_LENGTH, fp);
			expend_list[i] = (char *) malloc((strlen(buf)) * sizeof(char));
			strcpy(expend_list[i], buf);
			expend_list[i][strlen(buf)-2]='\0';
		}
		read_data->expend_list = expend_list;

	}

	return read_data;
}



static void mod_get_shared_folder(const char *res_file_in 	// file 이름 받아옴
		, char *res_path_out 							// 이 string을 공유할 폴더(MW)/file 로 바꿔줌
		)
{
	snprintf(res_path_out, RES_PATH_MAX, "%s%s", "/opt/usr/media/Others/", res_file_in);
	dlog_print(DLOG_DEBUG, "tag", "%s - PATH : %s", __func__, res_path_out);
}
