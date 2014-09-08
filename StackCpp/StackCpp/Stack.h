#include "stdafx.h"

#ifndef _STACK_H
#define _STACK_H

struct Node{
	int value;
	struct Node* next;
};

typedef Node* Stack;


void push(Stack *s, int value);
Node* pop(Stack *s);

#endif