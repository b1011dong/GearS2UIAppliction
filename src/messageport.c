/*
 * messageport.c
 *
 *  Created on: Oct 2, 2015
 *      Author: SON
 */
#include "s_txtform.h"
#include <message_port.h>
#include <time.h>
#include <app_control.h>
#include <dlog.h>


#define MESSAGE_PORT_FROM_UIAPP "m_port_uiapp"
#define MAX_PATH 260

//////////////////Port 부분
// 현재 시간 구해서 String으로 반환
char *current_time()
{
	time_t timer;
	struct tm *t;
	char *buf=(char *)malloc(sizeof(char)*20);

	timer = time(NULL); // 현재 시각을 초 단위로 얻기

	t = localtime(&timer); // 초 단위의 시간을 분리하여 구조체에 넣기

	sprintf(buf,"%04d-%02d-%02d %02d:%02d:%02d",
			t->tm_year + 1900,t->tm_mon + 1,t->tm_mday
			,t->tm_hour,t->tm_min,t->tm_sec);
	dlog_print(DLOG_INFO, "tag", "date_buf : %s",buf);
	return buf;
}
// 앱 시작 함수 (서비스 앱 켤때 사용)
void mod_create_app(char *app_path)
{
	app_control_h app_control;
	app_control_create(&app_control);
	app_control_set_operation(app_control, APP_CONTROL_OPERATION_DEFAULT);
	app_control_set_app_id(app_control, app_path);
	if (app_control_send_launch_request(app_control, NULL, NULL)
			== APP_CONTROL_ERROR_NONE)
		dlog_print(DLOG_INFO, "tag", "Succeeded to launch a %s app.",app_path);
	else
		dlog_print(DLOG_INFO, "tag", "Failed to launch a  %s app.",app_path);
	app_control_destroy(app_control);
}
// 포트가 열려있는지 확인하고 포트 안열려있으면 앱 시작시키는 함수
bool test_check_remote_port(char *remote_app_id) {
	int ret;
	bool found;
	dlog_print(DLOG_ERROR, "TAG",
			"%s", __func__);

	ret = message_port_check_remote_port(remote_app_id, MESSAGE_PORT_FROM_UIAPP,
			&found);
	if (ret != MESSAGE_PORT_ERROR_NONE) {
		dlog_print(DLOG_ERROR, "TAG",
				"%s - message_port_check_remote_port error : %d", __func__,ret);

	}
	else
	{
		dlog_print(DLOG_ERROR, "TAG",
						"check success");

	}

	return found;
}
// Service에 메세지 전달하는 함수
void send_used_money_message(char *remote_app_id,int used_money, char *used_category)
{
   int ret;
   char buf[20] ;

   bundle *b = bundle_create ();
   sprintf(buf,"%d",used_money);
   bundle_add_str (b, "used_money", buf);
   bundle_add_str (b, "used_category", used_category);
   sprintf(buf,"%s",current_time());
   bundle_add_str (b, "time", buf);
   ret = message_port_send_message (remote_app_id, MESSAGE_PORT_FROM_UIAPP, b);
   if (ret != MESSAGE_PORT_ERROR_NONE)
   {
      dlog_print(DLOG_ERROR, "TAG", "%s - message_port_check_remote_port error : %d",__func__, ret);
   }
   else
   {
      dlog_print(DLOG_INFO, "TAG", "Send message done");
   }
   bundle_free (b);
}

