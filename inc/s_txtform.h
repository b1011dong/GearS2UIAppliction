#include <tizen.h>
#include <dlog.h>

typedef struct _txtForm {
	int digit;				// 자릿수
	int total_money;		// 잔액
	int income_num;			// 수입 카테고리 갯수
	int expend_num;			// 지출 카테고리 갯수
	char** income_list;		// 수입 카테고리 리스트
	char** expend_list;		// 지출 카테고리 리스트
} txtForm;




