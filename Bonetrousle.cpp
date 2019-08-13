#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
#include <string>
#include <limits>
using namespace std;

int main() {
    int trips;
	cin >> trips;

	std::vector<long> sticks(trips), boxes(trips), allowedBoxes(trips);

	for (int t = 0; t < trips; t++)
		cin >> sticks[t] >> boxes[t] >> allowedBoxes[t];

	for (int t = 0; t < trips; t++)
	{
		long n=sticks[t], k=boxes[t], b=allowedBoxes[t];

		std::vector<long> values(b);

		long sum = 0;
		long i = 0;
		long max = std::numeric_limits<long>::max();
		do
		{
			long maxElem = abs(n - (b * (b - 1) / 2));
			if (k < maxElem)
				maxElem = k;

			if (maxElem > max)
			{
				break;
			}
			else if (maxElem == max)
				maxElem--;

			sum += maxElem;
			values[i] = maxElem;
			i++;

			n -= maxElem;
			k--;
			b--;
			max = maxElem;
		} while (i < allowedBoxes[t]);

		if (sum == sticks[t])
		{
			for (int j = 0; j < allowedBoxes[t]; j++)
			{
				cout << (j > 0 ? " " : "") << values[j];
			}
		}
		else
			cout << "-1";
		cout << endl;
	}
    
    return 0;
}
