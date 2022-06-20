## To listen to Stripe Webhooks

First add local listener on from [Stripe dashboard](https://dashboard.stripe.com/test/webhooks)

Install Stripe cli

```sh
$ brew install stripe/stripe-cli/stripe
```

Then on your local terminal:

```sh
# First have your API server running
$ cd API/
$ dotnet watch run

# Then from another terminal
$ stripe login
$ stripe listen -f http://localhost:5000/api/payments/webhook -e charge.succeeded
```

## Postgres DB

Run Postgres DB locally

```sh
$ pg_ctl -D /usr/local/var/postgres start
```

## Deploy changes to Heroku

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
