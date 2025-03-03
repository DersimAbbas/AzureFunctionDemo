# Chuck Norris Jokes via WhatsApp with Azure Functions & Twilio

This project demonstrates how to create an Azure Function using .NET 8 that fetches a random Chuck Norris joke from an external API and delivers it via Twilio's WhatsApp sandbox.
By using Ngrok we can use our localhost to fetch it from twilios endpoint online without using azure resources or deploying it to azure. Do not USE NGROK for anything else than testing locally as it exposes your IP publicly!
## Table of Contents
- [Prerequisites](##prerequisites)
- [Project Setup](#project-setup)
- [Local Testing with ngrok](#local-testing-with-ngrok)
- [Configuring Twilio WhatsApp Sandbox](#configuring-twilio-whatsapp-sandbox)


## Prerequisites

- **Twilio Account:** [Sign up for Twilio](https://www.twilio.com/try-twilio)
- **Twilio WhatsApp Sandbox:** [Setup instructions](https://www.twilio.com/console/sms/whatsapp/sandbox)
- **ngrok:** [Download ngrok](https://ngrok.com/download)

## Project-Setup

1. **Initialize the Azure Functions Project:**

   Open a terminal and run:
   ```bash
   git clone https://github.com/DersimAbbas/AzureFunctionDemo

2. **Locate the project folder and open the project with visual studio.**
3. **Install Twilio package via nuget package manager console or the solution, "Twilio" the one with the most downloads (60m+ downloads).**
4. **Follow the instructions to create A Twilio Account and set up your phone number in the Whatsapp Sandbox. On Twilios Website.**
You can find WhatsApp sandbox after creating an account here:
<img src="https://i.gyazo.com/d3576a6736f2cb011653774f788509e2.png" alt="Screenshot Description">

5. **After your account setup with Twilio now its time to download ngrok for local testing without creating azure resources.**

## Ngrok Download and setup.
1. **Download Ngrok from here [Link](https://ngrok.com/downloads/windows?tab=download)**
2. **drag and drop your Ngrok.exe file inside the project next to WhatsAppFunction.sln**
3. it should look something like this > <img src="https://i.gyazo.com/e6e4da876cbeafcd3f533a7899525136.png" alt="Screenshot Description">

### Configing Ngrok.
1. **open a new terminal Cmd/powershell, find your project directory and where the ngrok.exe is located at**
2. You can locate it by typing:
3. ```bash
   cd ( to your project directory path)
4. for my PC this is how it looks like:
   ```bash
    c:users\myname> cd source
    c:users\myname\source> cd repos
    c:users\myname\source\repos> cd whatsAppFunction
    c:users\myname\source\repos\WhatsAppFunction>: in here now you have to add auth token by copying the command from the download page and paste it in.
    ngrok config add-authtoken <token>

### start the project and then in  the other terminal
  **type:**    
 
    ngrok (your local host endpoint 5258 5723...  etc etc)
    

6. should now look like this:
<img src="https://i.gyazo.com/90447f6e26262bf815ed4f3311fba3a8.png" alt="Screenshot Description">
      
        

## Running the project and adding the endpoint to Twilio.
1.**Head to twilios WhatsApp sandbox.**
add the forwarding Ngrok http URL from the terminal. with your Functions endpoint
<img src="https://i.gyazo.com/eaa6e72e7b6e413f538fc1902b19d3a7.png" alt="Screenshot Description">

2.**Try it out by sending a message to Twilio in WhatsApp. Now it should respond with a chuck norris Joke!**

<img src="https://i.gyazo.com/bc1303fce537affddc35c669bf85ef86.png" alt="Screenshot Description">

# Congrats now you've set up a functional Azure Functions App!
