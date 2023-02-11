using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.T0157
{
    /// <summary>
    /// A set of zero or more CSS classes.
    /// </summary>
    /// <remarks>
    /// The <see cref="TypedString_NoImplicitConversion"/> strongly-typed string base type is used since Blazor WebAssembly cannot handle types with an implicit to-string conversion.
    /// See: <see href="https://github.com/dotnet/aspnetcore/issues/18042"/>
    /// </remarks>
    [StrongTypeMarker]
    public class CssSociety : TypedString_NoImplicitConversion, IStrongTypeMarker
    {
        public CssSociety(string value)
            : base(value)
        {
        }
    }
}
