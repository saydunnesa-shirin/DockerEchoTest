# DockerEchoTest

## Workflow

    1. Execute the run-docker-local.cmd file by double clicking it (Inside folder: docker)
    This will open a terminal where the docker commands will run to build, create image and run docker container for 
    both server and client (assuming docker is installed in the machine)
    After container creation is done, 2 new terminal window will open (1 for server, 1 for client)
    The terminal for client will print out the logs (for receiving messages from server)
    The terminal for server will open a bash where commands can be executed

    2. In the bash terminal for server execute the command 'python main.py'. This will run the python server script which expects messages to be entered.

    3. Write any messages and observe the log terminal for client where messages will be printed.

    4. To stop the server type 'quit' and execute.