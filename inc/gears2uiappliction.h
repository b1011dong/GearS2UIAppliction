#ifndef __gears2uiappliction_H__
#define __gears2uiappliction_H__

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "gears2uiappliction"

#if !defined(PACKAGE)
#define PACKAGE "org.example.gears2uiappliction"
#endif

#define EDJ_FILE "edje/gears2uiappliction.edj"
#define GRP_MAIN "main"


#endif /* __gears2uiappliction_H__ */

#include "s_txtform.h"

bool test_check_remote_port(char *remote_app_id);
void send_used_money_message(char *remote_app_id,int used_money, char *used_category);

txtForm *mod_read_file(char *dest);
static void mod_get_shared_folder(const char *res_file_in 	// file 이름 받아옴
		, char *res_path_out 							// 이 string을 공유할 폴더(MW)/file 로 바꿔줌
		);
