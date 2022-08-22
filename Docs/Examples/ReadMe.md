# Examples

## Prerequisites

Examples are written with the help of Visual Studio Code extension *REST Client*. Make sure you have it installed.

## How to run?

Every example `.http` file starts with a request to get authorization token. Call that first. Next, call any other request in the example file. The first call sets the auth header and the other requests use it.