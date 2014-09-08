#include "stdafx.h"
#include "Stack.h"
#include <stdio.h>
#include <stdlib.h>

int main()
{
	Stack s = NULL;
	push(&s, 1);
	push(&s, 2);
	push(&s, 3);

	printf("Pop: %d\n", pop(&s)->value);
	printf("Pop: %d\n", pop(&s)->value);

	printf("Press any key to continue...\n");
	getchar();
	return 0;
}