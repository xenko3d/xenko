// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Xenko Shader Mixin Code Generator.
// To generate it yourself, please install Xenko.VisualStudio.Package .vsix
// and re-save the associated .xkfx.
// </auto-generated>

using System;
using Xenko.Core;
using Xenko.Rendering;
using Xenko.Graphics;
using Xenko.Shaders;
using Xenko.Core.Mathematics;
using Buffer = Xenko.Graphics.Buffer;

namespace Xenko.Rendering.Images
{
    public static partial class AmbientOcclusionRawAOShaderKeys
    {
        public static readonly ValueParameterKey<Vector4> ProjInfo = ParameterKeys.NewValue<Vector4>();
        public static readonly ValueParameterKey<Vector4> ScreenInfo = ParameterKeys.NewValue<Vector4>();
        public static readonly ValueParameterKey<float> ParamProjScale = ParameterKeys.NewValue<float>(1);
        public static readonly ValueParameterKey<float> ParamIntensity = ParameterKeys.NewValue<float>(1);
        public static readonly ValueParameterKey<float> ParamBias = ParameterKeys.NewValue<float>(0.01f);
        public static readonly ValueParameterKey<float> ParamRadius = ParameterKeys.NewValue<float>(1);
        public static readonly ValueParameterKey<float> ParamRadiusSquared = ParameterKeys.NewValue<float>(1);
    }
}
