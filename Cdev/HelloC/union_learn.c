#include <stdlib.h>
#include <stdio.h>

union intParts {
	int theInt;
	char bytes[sizeof(int)];
};

struct operator {
	int type;
	union {
		int intNum;
		float floatNum;
		double doubleNum;
	};
};

union Coins {
	struct
	{
		int quarter;
		int dime;
		int nickel;
		int penny;
	};
	int Coins[4];
};

int union_main(void)
{
	union intParts parts;
	parts.theInt = 5968145;

	printf("The int is %i\nThe bytes are [%i, %i, %i, %i]\n",
		parts.theInt, parts.bytes[0], parts.bytes[1], parts.bytes[2], parts.bytes[3]);

	int theInt = parts.theInt;

	printf("The int is %i\nThe bytes are [%i, %i, %i, %i]\n",
		theInt, *((char*)&theInt + 0), *((char*)&theInt + 1), *((char*)&theInt + 2), *((char*)&theInt + 3));

	printf("The int is %i\nThe bytes are [%i, %i, %i, %i]\n",
		theInt, ((char*)&theInt)[0], ((char*)&theInt)[1], ((char*)&theInt)[2], ((char*)&theInt)[3]);

	struct operator op;

	op.type = 0;

	op.intNum = 352;

	union Coins change;

	printf("%i\n", sizeof(change));

	int result;

	for (int i = 0; i < sizeof(change) / sizeof(int); i++)
	{
		result = scanf_s("%i", change.Coins + i);
	}
	printf("There are %i quarters, %i dimes, %i nickels, and %i pennies\n",
		change.quarter, change.dime, change.nickel, change.penny);

	return EXIT_SUCCESS;
}