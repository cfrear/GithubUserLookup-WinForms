# GithubUserLookup-WinForms
WinForms / .NET 9 / VB.NET

For a recent job interview I was given the following technical test:
We require you to create an ASP.Net MVC (.Net Framework only) website with the following:
- A page containing a text box to enter a Username and a Submit button to search Github (using their api end points) for a user by their username.
- Have the back-end call the Github Users API (eg. https://api.github.com/users/robconery) to retrieve the user's name, location, and avatar url from the returned Json.
- Use the repos_url value in the response to then get a list of all the repos for the user.
- Do not use any other third-party tools such as Octokit or Githubkit for managing the api connection.
- On the results page, please show the username, location, avatar image, and then in a grid below these values show the 5 repositories with the highest stargazer_count.
- For each of the repos show the Name (provide a link to the repo from this field), Description, and the number of Stargazers.
- Ensure you consider valid input. Also consider what happens if the user cannot be found or if they don't have any repositories.
- Unit tests MUST be included.

I thought this was an interesting task, so I decided to rebuild what I had previously done, using tech that is better suited to this role.
I have also expanded upon the original task brief and added some additional features that I feel could demonstrate the sort of skills and understanding that would be relevant to the role.


This application assumes that the host machine has 2 other applications installed:
- Google Chrome
- Microsoft Excel


Basic Functionality:
After searching for any valid Github username, some basic user info and repository data is returned and displayed on a new form.
Filters allow the number of repos, and the way in which they are sorted to be customised.
The name of each repo is a hyperlink that will open the Github page for the repo in a web browser (Chrome).
The export button will produce an Excel document containing all the data currently displayed. This file can be found in the Resources folder of the project. (GithubUserLookup-WinForms\GithubUserLookup\Resources)
Previous searches are stored in a search history document, to make repeated searches easier. This .txt file can also be found in the Resources folder. (GithubUserLookup-WinForms\GithubUserLookup\Resources)


Known Issues:
- The Github Repos API returns paginated results which are sorted alphanumerically. In order to retrieve more that 100 repos, changes would need to be made to the code to retrieve each page of 100 results.
Currently, the maximum number of repos that can be returned is 100, and they will all be from the first page; therefore all from the beginning of the alphanumeric alphabet.
This means that in cases where a user has a large number of repos (eg, microsoft have 6000+), all of the repos returned have a name beginning with numbers, special characters, or "A".

- When selecting a username from the search history, the search is executed immediately upon click. Giving no time to change the filters. 
Because of this, filters must be set before using the search history dropdown.

- Repos with long descriptions make the results table less readable. 

- Various UI imprefections, such as resizing the form.

- Error handling should provide better user feedback