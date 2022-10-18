using System;
using System.Text;

namespace Exercise1
{
    public abstract class IntDynamicArray
    {
        const int ExpandMultiplyFactor = 2;
        protected int[] items;
        protected int count;

        #region Constructor

        protected IntDynamicArray()
        {
            items = new int[4];
            count = 0;
        }

        #endregion

        #region Properties

        public int Count
        {
            get { return count; }
        }

        #endregion

        #region Public methods

        public abstract void Add(int item);
        public abstract bool Remove(int item);
        public abstract int IndexOf(int item);


        public void Clear()
        {
            count = 0;
        }

        public override String ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                builder.Append(items[i]);
                if (i < count - 1)
                {
                    builder.Append(",");
                }
            }
            return builder.ToString();
        }

        #endregion

        #region Protected methods
        protected void Expand()
        {
            int[] newItems = new int[items.Length * ExpandMultiplyFactor];

            // copy elements from old array into new array
            for (int i = 0; i < items.Length; i++)
            {
                newItems[i] = items[i];
            }

            // change to use new array
            items = newItems;
        }

        #endregion
    }
}
