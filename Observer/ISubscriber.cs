﻿namespace Observer
{
    public interface ISubscriber
    {
        void Update(IPublisher publisher);
    }
}
