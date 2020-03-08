#include <stdlib.h>
#include <stdio.h>

typedef struct node {
	int val;
	struct node* next;
} node_t;

void print_list(node_t* head);

void push(node_t* head, int val);

void insert(node_t** head, int val);

int pop_first(node_t** head);

int remove_last(node_t* head);

int remove_by_index(node_t** head, int n);

int remove_by_value(node_t** head, int val);

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

	insert(&head, 15);

	print_list(head);

	pop_first(&head);

	print_list(head);

	//int retval = remove_by_index(head, 2);
	int retval = remove_by_value(head, 3);

	print_list(head);

	printf("%d\n", retval);

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

int pop_first(node_t** head)
{
	int retVal = -1;

	node_t* next_node = NULL;

	if (*head == NULL)
	{
		return -1;
	}

	next_node = (*head)->next;
	retVal = (*head)->val;
	free(*head);
	*head = next_node;
}

int remove_last(node_t* head)
{
	node_t* current = head;

	while (current->next != NULL)
	{
		current = current->next;
	}
}

int remove_by_index(node_t** head, int n)
{
	int index = 0;
	int retval = -1;
	node_t* current = head;
	node_t* temp_node = NULL;

	if (n == 0)
	{
		return pop_first(n);
	}

	for (index = 0; index < n - 1; index++)
	{
		if (current->next == NULL)
		{
			return -1;
		}
		current = current->next;
	}

	temp_node = current->next;
	retval = temp_node->val;
	current->next = temp_node->next;
	free(temp_node);

	return retval;
}

int remove_by_value(node_t** head, int val)
{
	node_t* current = head;
	node_t* temp_node = NULL;

	int retval = -1;

	temp_node = current;
	while (current->next != NULL)
	{
		if (current->val == val)
		{
			temp_node->next = current->next;
			retval = current->val;
			break;
		}
		else
		{
			temp_node = current;
			current = current->next;
		}
	}
}