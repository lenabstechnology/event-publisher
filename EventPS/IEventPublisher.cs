﻿﻿using System.Threading.Tasks;

 namespace EventPS
 {
     /// <summary>
     /// Represents an event publisher
     /// </summary>
     public interface IEventPublisher
     {
         /// <summary>
         /// Publish event to consumers
         /// </summary>
         /// <typeparam name="TEvent">Type of event</typeparam>
         /// <param name="event">Event object</param>
         Task PublishAsync<TEvent>(TEvent @event);
     }
 }