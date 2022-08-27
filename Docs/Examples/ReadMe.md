# Examples

This page details how to test the core functionality of the app.

## Prerequisites

Have Postman installed.

## Get Access Token

We use *OAuth2* - so we will be using LinkedIn as authentication provider and will be doing things on behalf of some user.

In Postman select *LinkedIn* environment (if you don't have one - create it and set `ClientId` and `ClientSecret` and base url - `api.linkedin.com` there). Go to *LinkedIn* collection (root), open *Authorisation* tab and scroll all the way down and click *Get New Access Token*.

If everything is set, you should be redirected to a LinkedIn page to do authorisation and have the token returned for you.