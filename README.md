# DockerEchoTest

## Workflow

1. Start docker containers:
- Execute the run-docker-local.cmd file by double-clicking it (Inside folder: docker)
- This will open a terminal where the docker commands will run to build, create images and run the docker container for both server and client(assuming docker is installed in the machine)
- After container creation is done, 2 new terminal windows will open (1 for server, 1 for client)
- The terminal for the client will print out the logs (for receiving messages from the server)
- The terminal for the server will open a bash where commands can be executed
2. In the bash terminal for the server execute the command 'python main.py'. This will run the python server script which expects messages to be entered.
3. Write any messages and observe the log terminal for the client where messages will be printed.
4. To stop the executed python script of the server type 'quit' and execute.