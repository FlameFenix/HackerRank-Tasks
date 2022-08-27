// See https://aka.ms/new-console-template for more information

int chapters = 5;

int chaptersLimitPerPage = 3;

List<int> problems = new List<int>
{
  4, 2, 6, 1, 10
};

int currentPage = 0;

int counter = 0;

for (int i = 0; i < chapters; i++)
{
    currentPage++;

    for (int j = 1; j <= problems[i]; j++)
    {
        if(j == currentPage)
        {
            counter++;
        }

        if(j % chaptersLimitPerPage == 0 && j < problems[i])
        {
            currentPage++;
        }
    }

}

Console.WriteLine(counter);

