﻿using FreeSql.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FreeSql.MsAccess.Curd
{

    class MsAccessDelete<T1> : Internal.CommonProvider.DeleteProvider<T1>
    {
        public MsAccessDelete(IFreeSql orm, CommonUtils commonUtils, CommonExpression commonExpression, object dywhere)
            : base(orm, commonUtils, commonExpression, dywhere)
        {
        }

        public override List<T1> ExecuteDeleted() => throw new NotImplementedException("FreeSql.Provider.MsAccess 未实现该功能");

#if net40
#else
        public override Task<List<T1>> ExecuteDeletedAsync(CancellationToken cancellationToken = default) => throw new NotImplementedException("FreeSql.Provider.MsAccess 未实现该功能");
#endif
    }
}
