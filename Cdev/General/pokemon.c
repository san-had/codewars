#include <stdlib.h>
#include <stdio.h>

int calculate_damage(const char* your_type, const char* opponent_type, int attack, int damage);

double get_effectiveness(const char* your_type, const char* opponent_type);

typedef struct {
	char* key;
	double value;
} effectiveness;

effectiveness* load_effectiveness();

char* get_key(const char* your_type, const char* opponent_type);

int main(void)
{
	//printf("%d\n", calculate_damage("fire", "water", 100, 100));
	//printf("%d\n", calculate_damage("grass", "water", 100, 100));
	//printf("%d\n", calculate_damage("electric", "fire", 100, 100));
	//printf("%d\n", calculate_damage("grass", "electric", 57, 19));
	//printf("%d\n", calculate_damage("grass", "water", 40, 40));
	//printf("%d\n", calculate_damage("grass", "fire", 35, 5));
	//printf("%d\n", calculate_damage("fire", "electric", 10, 2));

	//printf("%d\n", calculate_damage("fire", "water", 100, 100));
	//printf("%d\n", calculate_damage("electric", "fire", 24, 1));
	//printf("%d\n", calculate_damage("electric", "grass", 84, 1));

	printf("%d\n", calculate_damage("water", "water", 100, 100));
	printf("%d\n", calculate_damage("grass", "grass", 75, 1));
}

int calculate_damage(const char* your_type, const char* opponent_type, int attack, int defense)
{
	int damage = 50 * (attack / defense) * get_effectiveness(your_type, opponent_type);
	return damage;
}

double get_effectiveness(const char* your_type, const char* opponent_type)
{
	if (!strncmp(your_type, opponent_type, 20))
	{
		return 0.5;
	}

	double e_value = 1;

	char* key = get_key(your_type, opponent_type);

	effectiveness* effectivenesses = load_effectiveness();

	effectiveness e;

	for (int i = 0; i < 8; i++)
	{
		e = *(effectivenesses + i);

		int eq = strncmp(e.key, key, 20);
		if (!eq)
		{
			e_value = e.value;
			break;
		}
	}
	return e_value;
}

char* get_key(const char* your_type, const char* opponent_type)
{
	char* key = malloc(sizeof(char) * 30);
	strcpy(key, your_type);
	strcat(key, "-");
	strcat(key, opponent_type);
	return key;
}

effectiveness* load_effectiveness()
{
	//effectiveness* effectiveness_array = malloc(sizeof(effectiveness) * 8);
	//effectiveness e;
	//e.key = "electric-water";
	//e.value = 2;
	//effectiveness_array = &e;

	//e.key = "fire-grass";
	//e.value = 2;
	//effectiveness_array[1] = e;

	//e.key = "water-fire";
	//e.value = 2;
	//effectiveness_array[2] = e;

	//e.key = "grass-water";
	//e.value = 2;
	//effectiveness_array[3] = e;

	//e.key = "water-electric";
	//e.value = 0.5;
	//effectiveness_array[4] = e;

	//e.key = "grass-fire";
	//e.value = 0.5;
	//effectiveness_array[5] = e;

	//e.key = "fire-water";
	//e.value = 0.5;
	//effectiveness_array[6] = e;

	//e.key = "water-grass";
	//e.value = 0.5;
	//effectiveness_array[7] = e;

	effectiveness effectiveness_array[8] = {
		{"electric-water", 2},
		{"fire-grass", 2},
		{"water-fire", 2},
		{"grass-water", 2},
		{"water-electric", 0.5},
		{"grass-fire", 0.5},
		{"fire-water", 0.5},
		{"water-grass", 0.5}
		//{"electric-electric", 0.5},
		//{"fire-fire", 0.5},
		//{"grass-grass", 0.5},
		//{"water-water", 0.5}
	};

	return effectiveness_array;
}