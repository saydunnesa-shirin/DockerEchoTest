
FROM python:latest
WORKDIR /src
COPY EchoTestServer/ .

RUN pip install --upgrade pip && \
    pip install requests

CMD [ "python", "main.py"]