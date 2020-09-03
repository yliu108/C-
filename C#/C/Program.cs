using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    public class stk
    {
        private List<object> collection;
        
        public stk()
        {
            collection = new List<object>();
        }
        public void Push(object obj)
        {
            if (obj == null)
              throw new InvalidOperationException();
            else
            collection.Insert(0,obj);
        }
        public object Pop()
        {
            if (collection.Count != 0)
            {
                object returnV = collection.First();
                collection.RemoveAt(0);
                return returnV;
            }
            else
                throw new ArgumentException("Stack is empty");
        }
        public void clear()
        {
            collection.Clear();
        }
    }
    class Program
    {
        static void Main()
        {
            var a = new stk();
            a.Push(1);
            a.Push(2);
            a.Push(3);
            Console.WriteLine(a.Pop());
            Console.WriteLine(a.Pop());
            Console.WriteLine(a.Pop());
            //
            var workflow = new Workflow();
            workflow.Add(new VideoUploader());
            workflow.Add(new CallWebService());
            workflow.Add(new SendEmail());
            workflow.Add(new ChangeStatus());
            var engine = new WorkFLowEngine();
            engine.Run(workflow);
            Console.Read();
        }
    }
    public interface ITask
    {
        void Execute();
    }
    public interface IWorkflow
    {
        void Add(ITask task);
        void Remove(ITask task);
        IEnumerable<ITask> GetTasks();
    }
    public class Workflow:IWorkflow
    {
        private List<ITask> Tasks;
        public Workflow()
        {
            Tasks = new List<ITask>();
        }
        public void Add(ITask task)
        {
            Tasks.Add(task);
        }
        public void Remove(ITask task)
        {
            Tasks.Remove(task);
        }
        public IEnumerable<ITask> GetTasks()
        {
            return Tasks;
        }


    }
    public class WorkFLowEngine
    {
        public void Run(IWorkflow workflow)
        {

            foreach (ITask task in workflow.GetTasks())
            { 
                task.Execute(); 
            }
            
        }
    }
    class VideoUploader:ITask
    {
        public void Execute()
        {
            Console.WriteLine("Uploading a video.");
        }
    }
    class CallWebService : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Calling service.");
        }
    }
    class SendEmail : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Sending an email.");
        }
    }
    class ChangeStatus : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Status changed.");
        }
    }
}
