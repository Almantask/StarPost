# Diary

## Day 1

Cool idea (media posts on schedule), read Linked In docs to see whether it is possible to implement. Seems like it is.

The API part that interests me is: https://docs.microsoft.com/en-us/linkedin/marketing/usecases/page-management/organic-posts-usecase?view=li-lms-2022-08. Took quite awhile to find.

## Day 3

Apparently, need to create a Linked In page (company) for getting access to the API. Did that: https://www.linkedin.com/company/clean-code-paladin/

Had to not only create the app but also verify it as an admin of the page, following these steps: https://www.linkedin.com/help/linkedin/answer/a548360.

I also needed to request for access. Thought that would require some manual intervention and review by Linked In. But nope, it's just a button click. Can select from: learning, authenticating and marketing APIs without any questions asked.

Explored public Postman workspace of LinkedIn and figured I would port the examples to be version controlled, personalized, specialized and secure: https://www.postman.com/linkedin-developer-apis/workspace/linkedin-marketing-solutions/folder/16069442-1e1c3b59-6dc9-4b47-942d-9a36ac9cda6b?ctx=documentation

Next up tried getting the first request working. I managed to get a LinkedIn response from my request for auth token - it responded with invalid token. Unfortunately, all that wrapped in raw HTML. Restful Client VS Code extension currently does not support preview of responses in raw HTML, therefore, it is not really a convenient way of authorising. Will have to do it the classic way - using Postman.