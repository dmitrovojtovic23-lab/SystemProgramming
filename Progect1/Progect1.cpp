#include <iostream>
using namespace std;

int main() {
    int answer, A, B, res;
    cout << "Select operation" << endl;
    cout << "Select 1 if you want to add" << endl;
    cout << "Select 2 if you want to subtract" << endl;
    cout << "Select 3 to exit" << endl;

    cout << ">>> ";
    cin >> answer;
    while (answer != 3) {
        switch (answer) {
        case 1:
            cout << "Enter first number: ";
            cin >> A;
            cout << "Enter second number: ";
            cin >> B;
            res = A + B;
            cout << "Result: " << res << endl;
            break;
        case 2:
            cout << "Enter first number: ";
            cin >> A;
            cout << "Enter second number: ";
            cin >> B;
            res = A - B;
            cout << "Result: " << res << endl;
            break;
        case 3:
            cout << "Thanks for using";
            break;
        default:
            cout << "Invalid option. Try again." << endl;
            break;
        }

        cout << ">>> ";
        cin >> answer;
    }
}