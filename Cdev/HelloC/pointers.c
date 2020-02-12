#include <stdlib.h>
#include <stdio.h>

void double_swap(double* p0, double* p1);

int main(void) {
	double d1 = 5.01;
	double d2 = 3.12;

	double_swap(&d1, &d2);

	printf("d1 = % g\nd2 = % g ", d1, d2);

	return EXIT_SUCCESS;
}

void double_swap(double* p0, double* p1) {
	double tmp = *p0;
	*p0 = *p1;
	*p1 = tmp;
}