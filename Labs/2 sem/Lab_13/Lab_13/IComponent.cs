﻿namespace Lab_13
{
    public interface IComponent
    {
        string Title { get; set; }

        void Draw();

        IComponent Find(string title);
    }
}