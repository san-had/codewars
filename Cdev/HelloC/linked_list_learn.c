#include <stdlib.h>
#include <stdio.h>

typedef struct node {
	int val;
	struct node* next;
} node_t;

void print_list(node_t* head);

void push(node_t* head, int val);

void insert(node_t** head, int val);

int main(void) {
	node_t* head = NULL;

	head = (node_t*)malloc(sizeof(node_t));

	if (head == NULL)
	{
		return 1;
	}

	head->val = 1;
	head->next = (node_t*)malloc(sizeof(node_t));

	if (head->next != NULL)
	{
		head->next->val = 2;
		head->next->next = NULL;
	}

	push(head, 3);

	push(head, 4);

	insert(&head, 0);

	print_list(head);

	return EXIT_SUCCESS;
}

void print_list(node_t* head)
{
	node_t* current = head;

	while (current != NULL)
	{
		printf("%d\n", current->val);
		current = current->next;
	}
}

void push(node_t* head, int val)
{
	node_t* current = head;

	while (current->next != NULL)
	{
		current = current->next;
	}

	current->next = (node_t*)malloc(sizeof(node_t));

	if (current->next != NULL)
	{
		current->next->next = NULL;
		current->next->val = val;
	}
}

void insert(node_t** head, int val)
{
	node_t* new_node;
	new_node = (node_t*)malloc(sizeof(node_t));

	if (new_node != NULL)
	{
		new_node->val = val;
		new_node->next = *head;
		*head = new_node;
	}
}