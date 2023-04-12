# Review comments from Peter

## API improvement

- SHOULD document all error in swagger (missing 400)
- SHOULD format bad request as JSON
- CONSIDER return the delete resource in the response body (DELETE /products/{id})
- CONSIDER return a 404 error on invalid guid
- FIX the `DELETE /products/{id}` should return 404 if the product is not found (not its a 500 error)
