import requests

try:
    def sendMessage():
        while True:
            message = input("Please enter a message: ")
            if message.lower() != 'quit':
                headers = {
                    'Content-type': 'application/json',
                    'Accept': 'application/json'
                }
                base_url = "http://host.docker.internal:3001"
                final_url = "{0}/api/echo".format(base_url)

                payload = {"message": '{0}'.format(message)}
                response = requests.post(final_url, json=payload, headers=headers)

                print(response.status_code, response.reason)  # HTTP
            else:
                break

    sendMessage()
except EOFError as e:
    print(end="")
