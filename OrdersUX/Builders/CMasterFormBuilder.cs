using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.UX.Builders
{
    public class CMasterFormBuilder
    {
        public Form Product { get; set; }

        // --------------------------------------------------------------------------------
        public virtual void BuildDataModule()
        {
            // Override this on the concrete descendant class, to write the code that creates and initializes a custom data module.
            throw new NotImplementedException();
        }
        // --------------------------------------------------------------------------------
        public virtual void BuildBrowserView()
        {
            // Override this on the concrete descendant class, to write the code that creates a custom browser view
            throw new NotImplementedException();
        }
        // --------------------------------------------------------------------------------
        public virtual void BuildEntityView()
        {
            // Override this on the concrete descendant class,  to write the code that creates a custom entity view
            throw new NotImplementedException();
        }
        // --------------------------------------------------------------------------------
        public virtual void BuildForm()
        {
            // Override this on the concrete descendant class, to write the custom code that creates the master detail form
            throw new NotImplementedException();
        }
        // --------------------------------------------------------------------------------
    }
}
