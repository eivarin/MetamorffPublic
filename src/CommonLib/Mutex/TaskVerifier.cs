    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading;

    namespace CommonLib.MutexStuff
    {
        public static class TaskVerifier
        {
            private static bool firstApplicationInstanceBool;
            private static Mutex mutexApplication;

            //verifica se a aplicação já está aberta
            public static bool IsApplicationFirstInstance(string MutexName)
            {
                
                if (mutexApplication == null)
                {
                    mutexApplication = new Mutex(true, MutexName, out firstApplicationInstanceBool);
                }
                mutexApplication = null;
                return firstApplicationInstanceBool ;
            }
        }
    }
