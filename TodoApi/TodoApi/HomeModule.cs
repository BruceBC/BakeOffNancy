using System;
using Nancy;

namespace TodoApi
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/", args => "Hello World!");
        }
    }
}
