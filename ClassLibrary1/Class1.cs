using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Application
    {
        List<TaskList> taskLists;
        Application application;

        public static void GetApplication() 
        {

        }

    }
    public class TaskList
    {
        String name;
        List<Task> tasks;
    }
    public class Task
    {
        String Title;
        DateTime Due;
        Boolean Done;

    }
}
