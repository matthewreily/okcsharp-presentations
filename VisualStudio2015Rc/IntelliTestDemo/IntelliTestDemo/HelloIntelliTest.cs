using System.Collections.Generic;

namespace IntelliTestDemo
{
    public class HelloIntelliTest
    {
        public string GetHelloWorld(Message message)
        {
            return $"Thank you {message.Salutation}. Here is your Message {message.WelcomMessage}";
        }

        public List<int> Bubblesort(List<int> a)
        {
            int temp;
            for (int i = 1; i <= a.Count; i++)
            {

                for (int j = 0; j < a.Count - i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            return a;
        }
    }
}
