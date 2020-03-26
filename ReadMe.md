# Pub-Sub Sample
This _dotnet core_ project contains a simple implementation of an _in-memory_ pub-sub pattern (_PubSubSample.Messaging_) and a sample application that uses the messaging library.

## The Messaging Library
In this library, We have generic interfaces for publisher and subscription (``IPublisher<T>`` and ``ISubscription<T>``). In this design, the Type ``T`` determines the relationship between these two. This means published ``T1`` messages will be received by subscribers of a ``T1`` message but not by subscribers of a ``T2`` message.

## The Sample App
The sample application (_PubSubSample.SampleApp_) accepts _first name_ and _last name_, then displays two different formats of the complete name. Its usage of the _PubSubSample.Messaging_ library is as follows:
* When the name is read from console, a ``Name`` object is published.
* A display object is subscribed to the ``Name`` message and displays it in different formats once received.