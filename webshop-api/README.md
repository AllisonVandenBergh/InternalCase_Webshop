# Euricom Webshop - part webshop-api

## Quick Start
Check the readme on root level for more information on how to start the complete project.

## Expected mapping
- API Controller maps the Representation Request to the MediatR Command.
- MediatR handler maps the command to the Domein entity.
- MediatR handler maps it to a MediatR response.
- API Controller maps the MediatR response to the Representation Response.