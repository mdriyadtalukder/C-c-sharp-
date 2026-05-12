#include <bits/stdc++.h>
using namespace std;
int main()
{
    int x;
    cin >> x;
    while (x--)
    {
        string s1;
        bool b = false;
        cin >> s1;
        if (s1 == "YES")
        {
            b = true;
        }
        if (!b)
        {
            for (char &c : s1)
            {
                c = tolower(c);
            }
            char k;
            if (s1[0] == 'y')
            {
                k = 'e';
            }
            else if (s1[0] == 'e')
            {
                k = 's';
            }
            else if (s1[0] == 's')
            {
                k = 'y';
            }else{
                b=true;
            }
            for (int i = 1; i < s1.length(); i++)
            {
                if (s1[i] == k)
                {
                    if (k == 'y')
                    {
                        k = 'e';
                    }
                    else if (k == 'e')
                    {
                        k = 's';
                    }
                    else if (k == 's')
                    {
                        k = 'y';
                    }
                }
                else
                {
                    b = true;
                    break;
                }
            }
        }
        if (b)
        {
            cout << "NO" << endl;
        }
        else
        {
            cout << "YES" << endl;
        }
    }
}