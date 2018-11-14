#include <string>
#include <vector>
#include <windows.h>
#include <stdlib.h> 
#include <iostream>
using namespace std;

static void gotoxy(int x, int y) {
	COORD coord;
	coord.X = x; coord.Y = y;
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coord);
}

int main() {
	int M = 1;
	int x;
	vector<int> a;
	vector<int> m;
	vector<int> Ms;
	vector<int> y;
	int numberOfSystems;
	cout << "\n\tNumber of systems of congruence: ";
	cin >> numberOfSystems;
	int pos = 2;
	for (int i = 0; i < numberOfSystems; i++) {
		vector<int> aux;
		int firstVal, secondVal;
		cout << "\tx = ", cin >> firstVal;
		gotoxy(15, pos);
		pos++;
		cout << "mod ";
		cin >> secondVal;
		M *= secondVal;
		a.push_back(firstVal);
		m.push_back(secondVal);
	}

	for (int i = 0; i < numberOfSystems; i++) {
		int m2 = 1;
		for (int j = 0; j < numberOfSystems; j++) {
			if (i != j) {
				m2 *= m[j];
			}
		}
		Ms.push_back(m2);
	}
	cout << "\n\tM = " << M;
	cout << "\n";

	for (int i = 0; i < Ms.size(); i++) {
		string myStr = to_string(i);
		cout << "\n\tM" + myStr << " = " << Ms[i];
	}

	for (int i = 0; i < Ms.size(); i++) {
		int ai = 1;
		int mi = m[i];
		int Mi = Ms[i];
		while (Mi != 1) {
			Mi = Mi % mi;
			if (Mi != 1) {
				int aux = mi + 1;
				int multiply = aux / Mi;
				Mi = Mi * multiply;
				ai = ai * multiply;
			}
		}
		y.push_back(ai);
	}

	cout << "\n";
	for (int i = 0; i < Ms.size(); i++) {
		string myStr = to_string(i);
		cout << "\n\ty" + myStr << " = " << y[i];
	}
	cout << "\n\n\t";
	system("pause");
	return 0;
}