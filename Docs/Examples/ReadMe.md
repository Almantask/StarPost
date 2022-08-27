# Examples

This page details how to test the core functionality of the app.

## Prerequisites

Have Postman installed.

## LinkedIn

[Postman collection](https://www.postman.com/science-saganist-14161066/workspace/starpost/collection/14044638-51ad219c-5410-4041-a4f3-05e06d2d36aa?action=share&creator=14044638)

### Get Access Token

We use *OAuth2* - so we will be using LinkedIn as authentication provider and will be doing things on behalf of some user.

In Postman select *LinkedIn* environment (if you don't have one - create it and set `ClientId` and `ClientSecret` and base url - `api.linkedin.com` there, your `authorId`). Go to *LinkedIn* collection (root), open *Authorisation* tab and scroll all the way down and click *Get New Access Token*.

If everything is set, you should be redirected to a LinkedIn page to do authorisation and have the token returned for you.

### Create and Delete a Post

There is a Postman collection *LinkedIn/Posts* under which you can create and delete a post.