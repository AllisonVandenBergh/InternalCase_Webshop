# Review comments from Peter

## Some improvement for your documentation
  - SHOULD add some info about the prerequisites like docker, dotnet, node, etc.
  - SHOULD split the docker & `ef database update` into two steps. Maybe good to have a npm scripts for it.
  - SHOULD not indent markdown code blocks, it's already code once you add ```
  - SHOULD not write doc's for dummies, assume the reader knows how to use git, bash, docket, etc.
  - SHOULD not assume everyone has iTerm installed, don't use iTerm specific commands. Just tell how to start the dotNET and FE code.
  - SHOULD add comments for installing dotnet and node (prerequisites)
  - SHOULD add comments about M1 mac
  - SHOULD add info about URL (api & swagger)

More like:

### Quick Start

```bash
# run SQL Server in docker
docker-compose -f docker-compose.yml up -d

# run DB migration
dotnet ef database update --project webshop-api/Infrastructure --startup-project webshop-api/Api

# start DB
docker start webshop-database

# start API (BE)
dotnet run watch --project ${current_folder}/webshop-api/Api --launch-profile https

# start React SPA
cd ./webshop-web 
pnpm run dev
```

Or with provided npm scripts (or other)

```bash
npm run db:up
npm run db:migrate

npm run start:api

# ...
```

## API improvement

- SHOULD document all error in swagger (missing 400)
- SHOULD format bad request as JSON
- CONSIDER return the delete resource in the response body (DELETE /products/{id})
- CONSIDER return a 404 error on invalid guid
- FIX the `GET /products/{id}` should return 404 if the product is not found (not its a 500 error)
