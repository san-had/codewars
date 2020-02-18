#include <stdlib.h>
#include <stdio.h>

int calculate_damage(const char* your_type, const char* opponent_type, int attack, int damage);

int get_effectiveness(const char* your_type, const char* opponent_type);

typedef struct {
	char* key;
	int value;
} effectiveness;

effectiveness* load_effectiveness();

int main(void)
{
	printf("%d\n", calculate_damage("fire", "water", 100, 100));
}

int calculate_damage(const char* your_type, const char* opponent_type, int attack, int defense)
{
	int damage = 50 * (attack / defense) * get_effectiveness(your_type, opponent_type);
	return damage;
}

int get_effectiveness(const char* your_type, const char* opponent_type)
{
	int e_value = 1;

	char* key = 0;
	strcat(key, "huhu", 20);
	strcat(key, "-", 20);
	strcat(key, opponent_type, 20);

	effectiveness* effectivenesses = load_effectiveness();

	effectiveness e;

	for (int i = 0; i < 8; i++)
	{
		e = *(effectivenesses + i);

		int eq = strncmp(e.key, key);
		if (!eq)
		{
			e_value = e.value;
			break;
		}
	}
	return e_value;
}

effectiveness* load_effectiveness()
{
	effectiveness effectiveness_array[8];
	effectiveness e;
	e.key = "electric-water";
	e.value = 2;
	effectiveness_array[0] = e;

	e.key = "fire-grass";
	e.value = 2;
	effectiveness_array[0] = e;

	e.key = "water-fire";
	e.value = 2;
	effectiveness_array[0] = e;

	e.key = "grass-water";
	e.value = 2;
	effectiveness_array[0] = e;

	e.key = "water-electric";
	e.value = 0.5;
	effectiveness_array[0] = e;

	e.key = "grass-fire";
	e.value = 0.5;
	effectiveness_array[0] = e;

	e.key = "fire-water";
	e.value = 0.5;
	effectiveness_array[0] = e;

	e.key = "water-grass";
	e.value = 0.5;
	effectiveness_array[0] = e;

	return effectiveness_array;
}