// StackCpp.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "Stack.h"

void push(Stack *s, int value){
	Node* temp = new Node();
	temp->value = value;
	temp->next = NULL;

	if (*s == NULL){
		*s = temp;
	}
	temp->next = *s;
	*s = temp;
}

Node* pop(Stack *s){
	Node* temp;
	if (*s == NULL)
		return NULL;
	temp = *s;	
	*s = (*s)->next;
	temp->next = NULL;
	return temp;
}