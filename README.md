## Locally running the app

#### Postgres DB

Run Postgres DB locally

```sh
docker run --name dev -e POSTGRES_USER=appuser -e POSTGRES_PASSWORD=secret -p 5432:5432 -d postgres:latest
```

#### Run app locally on the terminal

Make sure the correct .NET SDK version is installed

```sh
# Run the API server and client app that was copied into wwwwroot
$ cd API/
$ dotnet watch run
```

#### To listen to Stripe Webhooks

Docs on adding local webhook listeners [Stripe dashboard](https://dashboard.stripe.com/test/webhooks)

Install Stripe cli if you haven't.

```sh
$ brew install stripe/stripe-cli/stripe
```

```sh
# In a separate terminal
$ stripe login
$ stripe listen -f http://localhost:5000/api/payments/webhook -e charge.succeeded
# this will allow post back payment from stripe when user checks out order and posts a payment
# then if successful it'll show up on Stripe dashboard under transactions
```

## Dockering the app (WIP)

```sh
cd API/
docker build -t vzmm/dnstore .
docker run --rm -it -p 8080:80 vzmm/dnstore # this is currently failing :(
```

## Deploy changes to Heroku (Deprecated)

https://dnstore.herokuapp.com

1. Rebuild the client app

```sh
cd client/
npm run build
```

2. Push to Github

```sh
git add . # check in all the changes to git
git push origin <branch>
```

3. Create a pull request to main branch on Github

4. Merge to main

The changes to main branch should auto-trigger a build on Heroku
