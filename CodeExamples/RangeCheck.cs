static bool RangeCheck(int Value, int Min, int Max) // a short function you can call on to do range checks, you should be able to program this yourself i just have it here as a test 
        {
            bool checkvalid = false;

            if (Value >= Min && Value <= Max)
            {
                checkvalid = true;
            }
            else
            {
                checkvalid = false;
            }

            return checkvalid;
        }
