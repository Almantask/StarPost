# Diary

## Day 1

Cool idea (media posts on schedule), read Linked In docs to see whether it is possible to implement. Seems like it is.

The API part that interests me is: https://docs.microsoft.com/en-us/linkedin/marketing/usecases/page-management/organic-posts-usecase?view=li-lms-2022-08. Took quite awhile to find.

## Day 3

Apparently, need to create a Linked In page (company) for getting access to the API. Did that: https://www.linkedin.com/company/clean-code-paladin/

Had to not only create the app but also verify it as an admin of the page, following these steps: https://www.linkedin.com/help/linkedin/answer/a548360.

I also needed to request for access. It requires manual intervention from LinkedIn. As I wait - let's prepare.

Explored public Postman workspace of LinkedIn and figured I would port the examples to be version controlled, personalized, specialized and secure: https://www.postman.com/linkedin-developer-apis/workspace/linkedin-marketing-solutions/folder/16069442-1e1c3b59-6dc9-4b47-942d-9a36ac9cda6b?ctx=documentation

Next up tried getting the first request working. I managed to get a LinkedIn response from my request for auth token - it responded with invalid token. Unfortunately, all that wrapped in raw HTML. Restful Client VS Code extension currently does not support preview of responses in raw HTML, therefore, it is not really a convenient way of authorising. Will have to do it the classic way - using Postman. Not a big loss. Now I can import a Postman colllection for LinkedIn API and have that out of the box.

Imported and cleaned up the example Postman collection provided by the official LinkedIn docs: https://www.postman.com/science-saganist-14161066/workspace/starpost/collection/14044638-51ad219c-5410-4041-a4f3-05e06d2d36aa?action=share&creator=14044638

Set my app-specific Oauth credential (ClientId and ClientSecret) to Postman environment variables. Getting token fails with missmatching redirect URI. I haven't set one yet.

Went back to OAuth settings of my LinkedIn app. Set redirect URI - https://google.com.

Tried again - vague error (literally, just that error in Postman console)

Added another redirect link to my app - the one Postman provides by default. Getting a different error - unauthorised scope. Probaby my access request still hasn't been approved yet. Let's wait for tomorrow.

## Day 4, 5, 6

No notification

## Day 7

Maybe it works? Retried getting the token - fail.
Googled the error:
`unauthorized_scope_error`

I discovered that if I want an access token - I will need "Sign In With LinkedIn" permission. Well duh... I am requesting a token through LinkedIn signup after all. Though it's a bit silly not to give the required permission and to put me (or any other developer) into an impossible state with just that one permission that I have requested initially (media).

Waited 1h for the permission to be confirmed (no notification, it just happens). Tried again getting the token - same error.

I'm in. All I had to do is to change the scopes to just what I need (the defaults were different): `w_member_social`. Doh!

Now let's go back to docs to read what exactly I can do with the posts API.