#include <iostream>
#include <cstdlib>  

#include <ctime>    


using namespace std;

// Task1

int main() 
{
    int n;
    cout << "Enter a number n: ";
    cin >> n;
    int i = 0;
    while (i <= n) {
        cout << i << " ";
        i++;
    }
    cout << "
        ";
}

// Task2
    int main() 
{
    int a, b;
    cout << "Enter two numbers (range): ";
    cin >> a >> b;

    if (a > b) {
        int temp = a;
        a = b;
        b = temp;
    }

    cout << "All numbers: ";
    for (int i = a; i <= b; i++) {
        cout << i << " ";
    }
    cout << ""
        Even numbers : ";
        for (int i = a; i <= b; i++) {
            if (i % 2 == 0) cout << i << " ";
        }
    cout << ""
        Odd numbers : ";
        for (int i = a; i <= b; i++) {
            if (i % 2 != 0) cout << i << " ";
        }
    cout << ""
        Divisible by 7 : ";
        for (int i = a; i <= b; i++) {
            if (i % 7 == 0) cout << i << " ";
        }
    cout << "";
}

// Task3
    int main() 
{
    int a, b, sum = 0;
    cout << "Enter two numbers (range): ";
    cin >> a >> b;

    if (a > b) {
        int temp = a;
        a = b;
        b = temp;
    }

    for (int i = a; i <= b; i++) {
        sum += i;
    }
    cout << "Sum of numbers = " << sum << "
        ";
}

// Task4
    int main() 
{
    int num, sum = 0;
    cout << "Enter numbers (0 to stop): ";
    do {
        cin >> num;
        sum += num;
    } while (num != 0);

    sum -= 0; 

    cout << "Sum = " << sum << "
        ";
}

// Task5
    int main() 
    {
    srand(time(0));
    int secret = rand() % 500 + 1;
    int guess, attempts = 0;

    cout << "Guess the number between 1 and 500 (enter 0 to exit):
        ";

        while (true) {
            cin >> guess;
            if (guess == 0) {
                cout << "You exited the game.";

                    break;
            }
            attempts++;

            if (guess == secret) {
                cout << "Correct! Attempts: " << attempts << "
                    ";
                    break;
            }
            else if (guess < secret) {
                cout << "Higher";

            }
            else {
                cout << "Lower";

            }
        }
}

//Task 6
void task6() {
    double usd_rate = 37.0;
    double eur_rate = 40.0;
    double amount;
    int choice;

    do {
        cout << "Currency converter:";

            cout << "1: USD to UAH";

            cout << "2: EUR to UAH";

            cout << "3: UAH to USD";

            cout << "4: UAH to EUR";

            cout << "5: Exit";

            cout << "Select option: ";
        cin >> choice;

        switch (choice) {
        case 1:
            cout << "Enter USD amount: ";
            cin >> amount;
            cout << amount << " USD = " << amount * usd_rate << " UAH
                ";
                break;
        case 2:
            cout << "Enter EUR amount: ";
            cin >> amount;
            cout << amount << " EUR = " << amount * eur_rate << " UAH
                ";
                break;
        case 3:
            cout << "Enter UAH amount: ";
            cin >> amount;
            cout << amount << " UAH = " << amount / usd_rate << " USD
                ";
                break;
        case 4:
            cout << "Enter UAH amount: ";
            cin >> amount;
            cout << amount << " UAH = " << amount / eur_rate << " EUR";
                break;
        case 5:
            cout << "Goodbye!";

                break;
        default:
            cout << "Wrong option";
        }

    } while (choice != 5);
}

int main() {
    task1();
    task2();
    task3();
    task4();
    task5();
    task6();
    return 0;
}
