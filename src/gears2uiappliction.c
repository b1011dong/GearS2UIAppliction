#include "gears2uiappliction.h"

#define INCOME 0
#define OUTGO 1
#define DEFAULT 0
#define READY_TO_CONFIRM 1
#define INOUT_BTN 10
#define DEL_BTN 11

typedef struct appdata{
	Evas_Object* win;
	Evas_Object* conform;
	Evas_Object* layout;
	Evas_Object* nf;
	Evas_Object* entry;
	Evas_Object **img;
	Evas_Object *genlist_category;
	Eext_Circle_Surface *circle_surface;
} appdata_s;

short inout_flag = 1; // 0: income, 1: outgo
short confirm_flag = 0; // 0: default, 1: ready to confirm(send)

static void
win_delete_request_cb(void *data, Evas_Object *obj, void *event_info)
{
	ui_app_exit();
}

static void
layout_back_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;
	/* Let window go to hide state. */
	//elm_win_lower(ad->win);
	ui_app_exit();
}

static void
app_get_resource(const char *edj_file_in, char *edj_path_out, int edj_path_max)
{
	char *res_path = app_get_resource_path();
	if (res_path) {
		snprintf(edj_path_out, edj_path_max, "%s%s", res_path, edj_file_in);
		free(res_path);
	}
}

static void
adjust_string(Evas_Object *entry)
{
}

static void
reverse_string(Evas_Object *entry)
{
	const char *temp;
	char *ch = NULL;
	char tempCh;
	int len;
	int i, j = 0;

	temp = elm_entry_entry_get(entry);
	if (!temp) return;
	ch = strdup(temp);

	len = strlen(ch);

	for(i = len-2; i >= len/2; i--)
	{
		tempCh = ch[i];
		ch[i] = ch[j];
		ch[j++] = tempCh;
	}

	elm_entry_entry_set(entry, ch);
}

static void
delete_string(Evas_Object *entry)
{
	const char *temp;
	char *ch = NULL;
	char tempCh;
	int len;
	int i, j = 0;

	temp = elm_entry_entry_get(entry);
	if (!temp) return;
	ch = strdup(temp);

	len = strlen(ch);

	if (len > 0)
	{
		ch[len-1] = ch[len];
		elm_entry_entry_set(entry, ch);
	}
	else
		elm_entry_entry_set(entry, "");
}

/* 누르면 뿅뿅 글자가 나타나게 할 것이다! */
static void
img_clicked_0_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *entry = data;

	if(confirm_flag == READY_TO_CONFIRM)
	{
		/*if(inout_flag == INCOME)
			elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#4cffba align=center'");
		else if(inout_flag == OUTGO)
			elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#ffffff align=center'");*/

		elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#ffffff align=center'");

		confirm_flag = DEFAULT;

		return;
	}

	if( (strdup( elm_entry_entry_get(entry)))[0] != '0' && strlen( strdup( elm_entry_entry_get(entry))) != 0)
	{
		if( strlen( strdup( elm_entry_entry_get(entry) ) ) < 8)
		{
			elm_entry_entry_append(entry, "0");
			adjust_string(entry);
		}
	}
}
static void
img_clicked_1_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *entry = data;

	if(confirm_flag == READY_TO_CONFIRM)
	{
		/*if(inout_flag == INCOME)
			elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#4cffba align=center'");
		else if(inout_flag == OUTGO)
			elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#ffffff align=center'");*/

		elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#ffffff align=center'");

		confirm_flag = DEFAULT;

		return;
	}

	if( strlen( strdup( elm_entry_entry_get(entry) ) ) < 8)
	{
		elm_entry_entry_append(entry, "1");
		adjust_string(entry);
	}
}
static void
img_clicked_2_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *entry = data;

	if(confirm_flag == READY_TO_CONFIRM)
	{
		/*if(inout_flag == INCOME)
			elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#4cffba align=center'");
		else if(inout_flag == OUTGO)
			elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#ffffff align=center'");*/

		elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#ffffff align=center'");

		confirm_flag = DEFAULT;

		return;
	}

	if( strlen( strdup( elm_entry_entry_get(entry) ) ) < 8)
	{
		elm_entry_entry_append(entry, "2");
		adjust_string(entry);
	}
}
static void
img_clicked_3_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *entry = data;

	if(confirm_flag == READY_TO_CONFIRM)
	{
		/*if(inout_flag == INCOME)
			elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#4cffba align=center'");
		else if(inout_flag == OUTGO)
			elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#ffffff align=center'");*/

		elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#ffffff align=center'");

		confirm_flag = DEFAULT;

		return;
	}

	if( strlen( strdup( elm_entry_entry_get(entry) ) ) < 8)
	{
		elm_entry_entry_append(entry, "3");
		adjust_string(entry);
	}
}
static void
img_clicked_4_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *entry = data;

	if(confirm_flag == READY_TO_CONFIRM)
	{
		/*if(inout_flag == INCOME)
			elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#4cffba align=center'");
		else if(inout_flag == OUTGO)
			elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#ffffff align=center'");*/

		elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#ffffff align=center'");

		confirm_flag = DEFAULT;

		return;
	}

	if( strlen( strdup( elm_entry_entry_get(entry) ) ) < 8)
	{
		elm_entry_entry_append(entry, "4");
		adjust_string(entry);
	}
}
static void
img_clicked_5_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *entry = data;

	if(confirm_flag == READY_TO_CONFIRM)
	{
		/*if(inout_flag == INCOME)
			elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#4cffba align=center'");
		else if(inout_flag == OUTGO)
			elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#ffffff align=center'");*/

		elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#ffffff align=center'");

		confirm_flag = DEFAULT;

		return;
	}

	if( strlen( strdup( elm_entry_entry_get(entry) ) ) < 8)
	{
		elm_entry_entry_append(entry, "5");
		adjust_string(entry);
	}
}
static void
img_clicked_6_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *entry = data;

	if(confirm_flag == READY_TO_CONFIRM)
	{
		/*if(inout_flag == INCOME)
			elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#4cffba align=center'");
		else if(inout_flag == OUTGO)
			elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#ffffff align=center'");*/

		elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#ffffff align=center'");

		confirm_flag = DEFAULT;

		return;
	}

	if( strlen( strdup( elm_entry_entry_get(entry) ) ) < 8)
	{
		elm_entry_entry_append(entry, "6");
		adjust_string(entry);
	}
}
static void
img_clicked_7_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *entry = data;

	if(confirm_flag == READY_TO_CONFIRM)
	{
		/*if(inout_flag == INCOME)
			elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#4cffba align=center'");
		else if(inout_flag == OUTGO)
			elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#ffffff align=center'");*/

		elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#ffffff align=center'");

		confirm_flag = DEFAULT;

		return;
	}

	if( strlen( strdup( elm_entry_entry_get(entry) ) ) < 8)
	{
		elm_entry_entry_append(entry, "7");
		adjust_string(entry);
	}
}
static void
img_clicked_8_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *entry = data;

	if(confirm_flag == READY_TO_CONFIRM)
	{
		/*if(inout_flag == INCOME)
			elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#4cffba align=center'");
		else if(inout_flag == OUTGO)
			elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#ffffff align=center'");*/

		elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#ffffff align=center'");

		confirm_flag = DEFAULT;

		return;
	}

	if( strlen( strdup( elm_entry_entry_get(entry) ) ) < 8)
	{
		elm_entry_entry_append(entry, "8");
		adjust_string(entry);
	}
}
static void
img_clicked_9_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *entry = data;

	if(confirm_flag == READY_TO_CONFIRM)
	{
		/*if(inout_flag == INCOME)
			elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#4cffba align=center'");
		else if(inout_flag == OUTGO)
			elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#ffffff align=center'");*/

		elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#ffffff align=center'");

		confirm_flag = DEFAULT;

		return;
	}

	if( strlen( strdup( elm_entry_entry_get(entry) ) ) < 8)
	{
		elm_entry_entry_append(entry, "9");
		adjust_string(entry);
	}
}
static void
img_clicked_inout_cb(void **data, Evas_Object *obj, void *event_info)
{
	//Evas_Object *entry = data;
	Evas_Object *entry;
	Evas_Object *state_img;
	Evas_Object *img = obj;
	char icon_path[PATH_MAX] = {0, };

	entry = (Evas_Object*)data[0];
	state_img = (Evas_Object*)data[1];
	//entry = (Evas_Object*)data;
	//state_img = (Evas_Object*)data;

	if(confirm_flag == READY_TO_CONFIRM)
	{
		/*if(inout_flag == INCOME)
			elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#4cffba align=center'");
		else if(inout_flag == OUTGO)
			elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#ffffff align=center'");*/

		elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#ffffff align=center'");

		confirm_flag = DEFAULT;

		return;
	}

	if(inout_flag == INCOME) // change current state: income -> outgo
	{
		// elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#ffffff align=center'");
		app_get_resource("edje/images/button_plus.png", icon_path, (int)PATH_MAX);
		elm_image_file_set(img, icon_path, NULL);

		app_get_resource("edje/images/state_minus.png", icon_path, (int)PATH_MAX);
		elm_image_file_set(state_img, icon_path, NULL);

		inout_flag = 1;
	}
	else if(inout_flag == OUTGO) // change current state: outgo -> income
	{
		// elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#4cffba align=center'");
		app_get_resource("edje/images/button_minus.png", icon_path, (int)PATH_MAX);
		elm_image_file_set(img, icon_path, NULL);

		app_get_resource("edje/images/state_plus.png", icon_path, (int)PATH_MAX);
		elm_image_file_set(state_img, icon_path, NULL);

		inout_flag = 0;
	}
}
static void
img_clicked_del_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *entry = data;

	if(confirm_flag == READY_TO_CONFIRM)
	{
		/*if(inout_flag == INCOME)
			elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#4cffba align=center'");
		else if(inout_flag == OUTGO)
			elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#ffffff align=center'");*/

		elm_entry_text_style_user_push(entry, "DEFAULT='font_size=40 color=#ffffff align=center'");

		confirm_flag = DEFAULT;

		return;
	}

	delete_string(entry);
}
static void
confirm_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *entry = obj;

	if(confirm_flag == DEFAULT)
	{
		elm_entry_text_style_user_push(entry, "DEFAULT='font_size=50 color=#fe5968 align=center'");
		confirm_flag = READY_TO_CONFIRM;
	}
	else if(confirm_flag == READY_TO_CONFIRM)
	{
		/* confirm */
	}
}

/* 버튼 등의 기본 화면을 나타낼 것이다! */
static void
create_main_view(appdata_s *ad)
{
	Evas_Object *box;
	Evas_Object *button;
	Evas_Object *icon;
	Evas_Object *grid;
	Evas_Object *state_img;
	Evas_Object **entry_w_image;

	Evas_Object *scroller = NULL;
	Evas_Object *circle_scroller = NULL;

	int i, j;
	char icon_path[PATH_MAX] = {0, };

	grid = elm_grid_add(ad->win);
	evas_object_size_hint_weight_set(grid, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(grid, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_object_content_set(ad->conform, grid);
	evas_object_show(grid);


	scroller = elm_scroller_add(grid);
	elm_scroller_loop_set(scroller, EINA_FALSE, EINA_FALSE);
	elm_scroller_page_size_set(scroller, 60, 0);
	elm_scroller_page_scroll_limit_set(scroller, 1, 0);
	elm_object_scroll_lock_y_set(scroller, EINA_TRUE);
	evas_object_show(scroller);
	elm_grid_pack(grid, scroller, 22, 20, 30, 30);

	circle_scroller = eext_circle_object_scroller_add(scroller, ad->circle_surface);
	eext_circle_object_scroller_policy_set(circle_scroller, ELM_SCROLLER_POLICY_AUTO, ELM_SCROLLER_POLICY_OFF);
	eext_rotary_object_event_activated_set(circle_scroller, EINA_TRUE);


	ad->img = (Evas_Object**)malloc(sizeof(Evas_Object*) * 12);

	app_get_resource("edje/images/button_0.png", icon_path, (int)PATH_MAX);
	ad->img[0] = elm_image_add(grid);
	elm_image_file_set(ad->img[0], icon_path, NULL);
	evas_object_show(ad->img[0]);
	elm_grid_pack(grid, ad->img[0], 42, 4, 16, 16);

	app_get_resource("edje/images/button_1.png", icon_path, (int)PATH_MAX);
	ad->img[1] = elm_image_add(grid);
	elm_image_file_set(ad->img[1], icon_path, NULL);
	evas_object_show(ad->img[1]);
	elm_grid_pack(grid, ad->img[1], 61, 10, 16, 16);

	app_get_resource("edje/images/button_2.png", icon_path, (int)PATH_MAX);
	ad->img[2] = elm_image_add(grid);
	elm_image_file_set(ad->img[2], icon_path, NULL);
	evas_object_show(ad->img[2]);
	elm_grid_pack(grid, ad->img[2], 75, 24, 16, 16);

	app_get_resource("edje/images/button_3.png", icon_path, (int)PATH_MAX);
	ad->img[3] = elm_image_add(grid);
	elm_image_file_set(ad->img[3], icon_path, NULL);
	evas_object_show(ad->img[3]);
	elm_grid_pack(grid, ad->img[3], 81, 43, 16, 16);

	app_get_resource("edje/images/button_4.png", icon_path, (int)PATH_MAX);
	ad->img[4] = elm_image_add(grid);
	elm_image_file_set(ad->img[4], icon_path, NULL);
	evas_object_show(ad->img[4]);
	elm_grid_pack(grid, ad->img[4], 74, 61, 16, 16);

	app_get_resource("edje/images/button_5.png", icon_path, (int)PATH_MAX);
	ad->img[5] = elm_image_add(grid);
	elm_image_file_set(ad->img[5], icon_path, NULL);
	evas_object_show(ad->img[5]);
	elm_grid_pack(grid, ad->img[5], 61, 75, 16, 16);

	app_get_resource("edje/images/button_6.png", icon_path, (int)PATH_MAX);
	ad->img[6] = elm_image_add(grid);
	elm_image_file_set(ad->img[6], icon_path, NULL);
	evas_object_show(ad->img[6]);
	elm_grid_pack(grid, ad->img[6], 42, 81, 16, 16);

	app_get_resource("edje/images/button_7.png", icon_path, (int)PATH_MAX);
	ad->img[7] = elm_image_add(grid);
	elm_image_file_set(ad->img[7], icon_path, NULL);
	evas_object_show(ad->img[7]);
	elm_grid_pack(grid, ad->img[7], 23, 75, 16, 16);

	app_get_resource("edje/images/button_8.png", icon_path, (int)PATH_MAX);
	ad->img[8] = elm_image_add(grid);
	elm_image_file_set(ad->img[8], icon_path, NULL);
	evas_object_show(ad->img[8]);
	elm_grid_pack(grid, ad->img[8], 10, 61, 16, 16);

	app_get_resource("edje/images/button_9.png", icon_path, (int)PATH_MAX);
	ad->img[9] = elm_image_add(grid);
	elm_image_file_set(ad->img[9], icon_path, NULL);
	evas_object_show(ad->img[9]);
	elm_grid_pack(grid, ad->img[9], 4, 43, 16, 16);

	app_get_resource("edje/images/button_plus.png", icon_path, (int)PATH_MAX);
	ad->img[INOUT_BTN] = elm_image_add(grid);
	elm_image_file_set(ad->img[INOUT_BTN], icon_path, NULL);
	evas_object_show(ad->img[INOUT_BTN]);
	elm_grid_pack(grid, ad->img[INOUT_BTN], 10, 24, 16, 16);

	app_get_resource("edje/images/button_del.png", icon_path, (int)PATH_MAX);
	ad->img[DEL_BTN] = elm_image_add(grid);
	elm_image_file_set(ad->img[DEL_BTN], icon_path, NULL);
	evas_object_show(ad->img[DEL_BTN]);
	elm_grid_pack(grid, ad->img[DEL_BTN], 23, 10, 16, 16);

	app_get_resource("edje/images/state_minus.png", icon_path, (int)PATH_MAX);
	state_img = elm_image_add(grid);
	elm_image_file_set(state_img, icon_path, NULL);
	evas_object_show(state_img);
	elm_grid_pack(grid, state_img, 42, 25, 16, 16);

	ad->entry = elm_entry_add(grid);
	elm_entry_editable_set(ad->entry, EINA_FALSE);
	elm_entry_single_line_set(ad->entry, EINA_TRUE);
	elm_entry_text_style_user_push(ad->entry, "DEFAULT='font_size=40 color=#ffffff align=center'");
	elm_entry_entry_set(ad->entry, "");
	evas_object_show(ad->entry);
	elm_grid_pack(grid, ad->entry, 25, 30, 50, 40);

	entry_w_image = (Evas_Object**)malloc(sizeof(Evas_Object*) * 2);

	entry_w_image[0] = ad->entry;
	entry_w_image[1] = state_img;

	evas_object_smart_callback_add(ad->img[0], "clicked", img_clicked_0_cb, ad->entry);
	evas_object_smart_callback_add(ad->img[1], "clicked", img_clicked_1_cb, ad->entry);
	evas_object_smart_callback_add(ad->img[2], "clicked", img_clicked_2_cb, ad->entry);
	evas_object_smart_callback_add(ad->img[3], "clicked", img_clicked_3_cb, ad->entry);
	evas_object_smart_callback_add(ad->img[4], "clicked", img_clicked_4_cb, ad->entry);
	evas_object_smart_callback_add(ad->img[5], "clicked", img_clicked_5_cb, ad->entry);
	evas_object_smart_callback_add(ad->img[6], "clicked", img_clicked_6_cb, ad->entry);
	evas_object_smart_callback_add(ad->img[7], "clicked", img_clicked_7_cb, ad->entry);
	evas_object_smart_callback_add(ad->img[8], "clicked", img_clicked_8_cb, ad->entry);
	evas_object_smart_callback_add(ad->img[9], "clicked", img_clicked_9_cb, ad->entry);
	evas_object_smart_callback_add(ad->img[INOUT_BTN], "clicked", img_clicked_inout_cb, entry_w_image);
	evas_object_smart_callback_add(ad->img[DEL_BTN], "clicked", img_clicked_del_cb, ad->entry);
	evas_object_smart_callback_add(ad->entry, "clicked", confirm_clicked_cb, NULL);
}

static void
create_base_gui(appdata_s *ad)
{
	char edj_path[PATH_MAX] = {0, };

	// Window
	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
	elm_win_conformant_set(ad->win, EINA_TRUE);
	elm_win_autodel_set(ad->win, EINA_TRUE);

	if (elm_win_wm_rotation_supported_get(ad->win)) {
		int rots[4] = { 0, 90, 180, 270 };
		elm_win_wm_rotation_available_rotations_set(ad->win, (const int *)(&rots), 4);
	}

	evas_object_smart_callback_add(ad->win, "delete,request", win_delete_request_cb, NULL);

	// Conformant
	ad->conform = elm_conformant_add(ad->win);
	elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW);
	elm_win_indicator_opacity_set(ad->win, ELM_WIN_INDICATOR_OPAQUE);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(ad->conform, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_win_resize_object_add(ad->win, ad->conform);
	eext_object_event_callback_add(ad->conform, EEXT_CALLBACK_BACK, layout_back_cb, ad);
	evas_object_show(ad->conform);

	// Eext Circle Surface Creation
	ad->circle_surface = eext_circle_surface_conformant_add(ad->conform);

	create_main_view(ad);

	/*
	// Naviframe
	ad->nf = elm_naviframe_add(ad->conform);
	elm_object_content_set(ad->conform, ad->nf);
	evas_object_size_hint_weight_set(ad->nf, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(ad->nf, EVAS_HINT_FILL, EVAS_HINT_FILL);
	eext_object_event_callback_add(ad->nf, EEXT_CALLBACK_BACK, eext_naviframe_back_cb, NULL);
	*/

	// Circle Surface
	// ad->circle_surface = eext_circle_surface_naviframe_add(ad->nf);

	// Show window after base gui is set up
	evas_object_show(ad->win);
}

static bool
app_create(void *data)
{
	/* Hook to take necessary actions before main event loop starts
	   Initialize UI resources and application's data
	   If this function returns true, the main loop of application starts
	   If this function returns false, the application is terminated */
	appdata_s *ad = data;

	create_base_gui(ad);

	return true;
}

static void
app_control(app_control_h app_control, void *data)
{
	/* Handle the launch request. */
}

static void
app_pause(void *data)
{
	/* Take necessary actions when application becomes invisible. */
}

static void
app_resume(void *data)
{
	/* Take necessary actions when application becomes visible. */
}

static void
app_terminate(void *data)
{
	/* Release all resources. */
}

static void
ui_app_lang_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LANGUAGE_CHANGED*/
	char *locale = NULL;
	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_LANGUAGE, &locale);
	elm_language_set(locale);
	free(locale);
	return;
}

static void
ui_app_orient_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
	return;
}

static void
ui_app_region_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void
ui_app_low_battery(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_BATTERY*/
}

static void
ui_app_low_memory(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_MEMORY*/
}

int
main(int argc, char *argv[])
{
	appdata_s ad = {0,};
	int ret = 0;

	ui_app_lifecycle_callback_s event_callback = {0,};
	app_event_handler_h handlers[5] = {NULL, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED], APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);
	ui_app_remove_event_handler(handlers[APP_EVENT_LOW_MEMORY]);

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "ui_app_main() is failed. err = %d", ret);
	}

	return ret;
}
