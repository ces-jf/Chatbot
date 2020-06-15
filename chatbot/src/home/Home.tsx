import React, { useState, useEffect } from "react";
import { GiftedChat, IMessage, Send } from "react-native-gifted-chat";
import { Dialogflow_V2 } from "react-native-dialogflow";

import { SendImage, ImageContainer } from "./styles";

const Home: React.FC = () => {
  useEffect(() => {
    Dialogflow_V2.setConfiguration(
      "dialogflow-iyvrpp@tcc-naxmuf.iam.gserviceaccount.com",
      "",
      Dialogflow_V2.LANG_PORTUGUESE_BRAZIL,
      "tcc-naxmuf"
    );
  }, []);

  const [messages, setMessages] = useState<IMessage[]>([]);

  const onSend = (messages: IMessage[] = []) => {
    setMessages((previousMessages) =>
      GiftedChat.append(previousMessages, messages)
    );
    messages.forEach((message) => {
      console.log(message.text);
      Dialogflow_V2.requestQuery(
        message.text,
        (result: any) => {
          console.log(result);
          messages = [
            {
              _id: result.responseId,
              text: result.queryResult.fulfillmentText,
              createdAt: new Date(),
              user: {
                _id: 2,
                name: "BotCES",
                avatar:
                  "https://media-exp1.licdn.com/dms/image/C4D0BAQEKFuOhxeKu5g/company-logo_200_200/0?e=2159024400&v=beta&t=aCUP__sttW5MT_dgjvASDa7NyzCTUDYj9DOGx94rCho",
              },
            },
          ];
          setMessages((previousMessages) =>
            GiftedChat.append(previousMessages, messages)
          );
        },
        (error: any) => console.log(error)
      );
    });
  };

  return (
    <>
      <GiftedChat
        messages={messages}
        onSend={(messages) => onSend(messages)}
        placeholder="Escreva aqui..."
        locale="pt-BR"
        renderSend={(props) => (
          <Send {...props}>
            <ImageContainer>
              <SendImage source={require("../../assets/send.png")} />
            </ImageContainer>
          </Send>
        )}
        onQuickReply={(asd) =>
          onSend([
            {
              _id: 123,
              text: asd[0].value,
              createdAt: new Date(),
              user: {
                _id: 1,
                name: "User",
                avatar: "https://placeimg.com/140/140/any",
              },
            },
          ])
        }
        user={{
          _id: 1,
        }}
      />
    </>
  );
};

export default Home;
