# Sample ASP.NET Core web API written while learning creating self-contained apps with Docker.

## Overview
The application runs in Docker containers - the web API connects to a PostgreSQL server that runs in a separate container (which has the postgres default port 5432 exposed). You can then use a client of your own, which can be a web browser or a tool like Postman, to communicate with the API.

## Starting the app
You need to install [Docker Engine](https://docs.docker.com/engine/install/) and [Docker Compose](https://docs.docker.com/compose/install/). Check the required steps for installation specific to your platform. You also need the Docker Engine running before you proceed with the following steps.

+ Clone the repository or download the source code.
+ Open a terminal window from the folder containing the ```docker-compose.yml``` file or navigate to that folder on your terminal.
+ Execute ```docker-compose up -d``` to start the application. Docker will automatically download all the necessary files required for the application and will set up a container with PostgreSQL server running. You can connect to ```http://localhost:5000/swagger``` from a web browser to see the API documentation.
+ When you're done with the application, execute ```docker-compose down --rmi all --volumes``` to shut down the containers and remove all files associated with the application.