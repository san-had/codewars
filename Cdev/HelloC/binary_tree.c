#include <stdlib.h>
#include <stdio.h>

typedef struct node
{
	int val;
	struct node* left;
	struct node* right;
} node_t;

void insert_tree(node_t* tree, int val);
void print_tree(node_t* current);
void printDFS(node_t* current);

int main(void)
{
	node_t* test_list = (node_t*)malloc(sizeof(node_t));
	if (test_list != NULL)
	{
		test_list->val = 0;
		test_list->left = NULL;
		test_list->right = NULL;

		insert_tree(test_list, 5);
		insert_tree(test_list, 8);
		insert_tree(test_list, 4);
		insert_tree(test_list, 3);
	}

	printDFS(test_list);
	printf("\n");

	return EXIT_SUCCESS;
}

void insert_tree(node_t* tree, int val)
{
	if (tree->val == 0)
	{
		tree->val = val;
	}
	else
	{
		if (val < tree->val)
		{
			if (tree->left != NULL)
			{
				insert_tree(tree->left, val);
			}
			else
			{
				tree->left = (node_t*)malloc(sizeof(node_t));
				if (tree->left != NULL)
				{
					tree->left->val = val;
					tree->left->left = NULL;
					tree->left->right = NULL;
				}
			}
		}
		else
		{
			if (tree->right != NULL)
			{
				insert_tree(tree->right, val);
			}
			else
			{
				tree->right = (node_t*)malloc(sizeof(node_t));
				if (tree->right != NULL)
				{
					tree->right->val = val;
					tree->right->left = NULL;
					tree->right->right = NULL;
				}
			}
		}
	}
}

void printDFS(node_t* current)
{
	if (current == NULL)
	{
		return;
	}
	if (current != NULL)
	{
		printf("%d ", current->val);
	}
	if (current->left != NULL)
	{
		printDFS(current->left);
	}
	if (current->right != NULL)
	{
		printDFS(current->right);
	}
}