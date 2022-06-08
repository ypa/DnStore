# To listen to Stripe Webhooks

First add local listener on from [Stripe dashboard](https://dashboard.stripe.com/test/webhooks)

Install Stripe cli

```sh
$ brew install stripe/stripe-cli/stripe
```

Then on your local terminal:

```sh
# First have your API server running
$ dotnet watch run

# Then from another terminal
$ stripe login
$ stripe listen -f http://localhost:5000/api/payments/webhook -e charge.succeeded
```
