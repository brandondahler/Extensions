
namespace Microsoft.Extensions.DependencyInjection.Tests.Utils.LargeServiceGraph
{

    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddLargeServiceGraph(this IServiceCollection serviceCollection, ServiceLifetime serviceLifetime)
        {
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS1), typeof(LS1), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS2), typeof(LS2), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS3), typeof(LS3), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS4), typeof(LS4), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS5), typeof(LS5), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS6), typeof(LS6), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS7), typeof(LS7), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS8), typeof(LS8), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS9), typeof(LS9), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS10), typeof(LS10), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS11), typeof(LS11), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS12), typeof(LS12), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS13), typeof(LS13), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS14), typeof(LS14), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS15), typeof(LS15), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS16), typeof(LS16), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS17), typeof(LS17), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS18), typeof(LS18), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS19), typeof(LS19), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS20), typeof(LS20), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS21), typeof(LS21), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS22), typeof(LS22), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS23), typeof(LS23), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS24), typeof(LS24), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS25), typeof(LS25), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS26), typeof(LS26), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS27), typeof(LS27), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS28), typeof(LS28), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS29), typeof(LS29), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS30), typeof(LS30), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS31), typeof(LS31), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS32), typeof(LS32), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS33), typeof(LS33), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS34), typeof(LS34), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS35), typeof(LS35), serviceLifetime));
            serviceCollection.Add(ServiceDescriptor.Describe(typeof(LS36), typeof(LS36), serviceLifetime));
            return serviceCollection;
        }
    }

    public class LS1
    {
        public LS1(LS2 ls2, LS3 ls3, LS4 ls4, LS5 ls5, LS6 ls6, LS7 ls7, LS8 ls8, LS9 ls9, LS10 ls10, LS11 ls11, LS12 ls12, LS13 ls13, LS14 ls14, LS15 ls15, LS16 ls16, LS17 ls17, LS18 ls18, LS19 ls19, LS20 ls20, LS21 ls21, LS22 ls22, LS23 ls23, LS24 ls24, LS25 ls25, LS26 ls26, LS27 ls27, LS28 ls28, LS29 ls29, LS30 ls30, LS31 ls31, LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS2
    {
        public LS2(LS3 ls3, LS4 ls4, LS5 ls5, LS6 ls6, LS7 ls7, LS8 ls8, LS9 ls9, LS10 ls10, LS11 ls11, LS12 ls12, LS13 ls13, LS14 ls14, LS15 ls15, LS16 ls16, LS17 ls17, LS18 ls18, LS19 ls19, LS20 ls20, LS21 ls21, LS22 ls22, LS23 ls23, LS24 ls24, LS25 ls25, LS26 ls26, LS27 ls27, LS28 ls28, LS29 ls29, LS30 ls30, LS31 ls31, LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS3
    {
        public LS3(LS4 ls4, LS5 ls5, LS6 ls6, LS7 ls7, LS8 ls8, LS9 ls9, LS10 ls10, LS11 ls11, LS12 ls12, LS13 ls13, LS14 ls14, LS15 ls15, LS16 ls16, LS17 ls17, LS18 ls18, LS19 ls19, LS20 ls20, LS21 ls21, LS22 ls22, LS23 ls23, LS24 ls24, LS25 ls25, LS26 ls26, LS27 ls27, LS28 ls28, LS29 ls29, LS30 ls30, LS31 ls31, LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS4
    {
        public LS4(LS5 ls5, LS6 ls6, LS7 ls7, LS8 ls8, LS9 ls9, LS10 ls10, LS11 ls11, LS12 ls12, LS13 ls13, LS14 ls14, LS15 ls15, LS16 ls16, LS17 ls17, LS18 ls18, LS19 ls19, LS20 ls20, LS21 ls21, LS22 ls22, LS23 ls23, LS24 ls24, LS25 ls25, LS26 ls26, LS27 ls27, LS28 ls28, LS29 ls29, LS30 ls30, LS31 ls31, LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS5
    {
        public LS5(LS6 ls6, LS7 ls7, LS8 ls8, LS9 ls9, LS10 ls10, LS11 ls11, LS12 ls12, LS13 ls13, LS14 ls14, LS15 ls15, LS16 ls16, LS17 ls17, LS18 ls18, LS19 ls19, LS20 ls20, LS21 ls21, LS22 ls22, LS23 ls23, LS24 ls24, LS25 ls25, LS26 ls26, LS27 ls27, LS28 ls28, LS29 ls29, LS30 ls30, LS31 ls31, LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS6
    {
        public LS6(LS7 ls7, LS8 ls8, LS9 ls9, LS10 ls10, LS11 ls11, LS12 ls12, LS13 ls13, LS14 ls14, LS15 ls15, LS16 ls16, LS17 ls17, LS18 ls18, LS19 ls19, LS20 ls20, LS21 ls21, LS22 ls22, LS23 ls23, LS24 ls24, LS25 ls25, LS26 ls26, LS27 ls27, LS28 ls28, LS29 ls29, LS30 ls30, LS31 ls31, LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS7
    {
        public LS7(LS8 ls8, LS9 ls9, LS10 ls10, LS11 ls11, LS12 ls12, LS13 ls13, LS14 ls14, LS15 ls15, LS16 ls16, LS17 ls17, LS18 ls18, LS19 ls19, LS20 ls20, LS21 ls21, LS22 ls22, LS23 ls23, LS24 ls24, LS25 ls25, LS26 ls26, LS27 ls27, LS28 ls28, LS29 ls29, LS30 ls30, LS31 ls31, LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS8
    {
        public LS8(LS9 ls9, LS10 ls10, LS11 ls11, LS12 ls12, LS13 ls13, LS14 ls14, LS15 ls15, LS16 ls16, LS17 ls17, LS18 ls18, LS19 ls19, LS20 ls20, LS21 ls21, LS22 ls22, LS23 ls23, LS24 ls24, LS25 ls25, LS26 ls26, LS27 ls27, LS28 ls28, LS29 ls29, LS30 ls30, LS31 ls31, LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS9
    {
        public LS9(LS10 ls10, LS11 ls11, LS12 ls12, LS13 ls13, LS14 ls14, LS15 ls15, LS16 ls16, LS17 ls17, LS18 ls18, LS19 ls19, LS20 ls20, LS21 ls21, LS22 ls22, LS23 ls23, LS24 ls24, LS25 ls25, LS26 ls26, LS27 ls27, LS28 ls28, LS29 ls29, LS30 ls30, LS31 ls31, LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS10
    {
        public LS10(LS11 ls11, LS12 ls12, LS13 ls13, LS14 ls14, LS15 ls15, LS16 ls16, LS17 ls17, LS18 ls18, LS19 ls19, LS20 ls20, LS21 ls21, LS22 ls22, LS23 ls23, LS24 ls24, LS25 ls25, LS26 ls26, LS27 ls27, LS28 ls28, LS29 ls29, LS30 ls30, LS31 ls31, LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS11
    {
        public LS11(LS12 ls12, LS13 ls13, LS14 ls14, LS15 ls15, LS16 ls16, LS17 ls17, LS18 ls18, LS19 ls19, LS20 ls20, LS21 ls21, LS22 ls22, LS23 ls23, LS24 ls24, LS25 ls25, LS26 ls26, LS27 ls27, LS28 ls28, LS29 ls29, LS30 ls30, LS31 ls31, LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS12
    {
        public LS12(LS13 ls13, LS14 ls14, LS15 ls15, LS16 ls16, LS17 ls17, LS18 ls18, LS19 ls19, LS20 ls20, LS21 ls21, LS22 ls22, LS23 ls23, LS24 ls24, LS25 ls25, LS26 ls26, LS27 ls27, LS28 ls28, LS29 ls29, LS30 ls30, LS31 ls31, LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS13
    {
        public LS13(LS14 ls14, LS15 ls15, LS16 ls16, LS17 ls17, LS18 ls18, LS19 ls19, LS20 ls20, LS21 ls21, LS22 ls22, LS23 ls23, LS24 ls24, LS25 ls25, LS26 ls26, LS27 ls27, LS28 ls28, LS29 ls29, LS30 ls30, LS31 ls31, LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS14
    {
        public LS14(LS15 ls15, LS16 ls16, LS17 ls17, LS18 ls18, LS19 ls19, LS20 ls20, LS21 ls21, LS22 ls22, LS23 ls23, LS24 ls24, LS25 ls25, LS26 ls26, LS27 ls27, LS28 ls28, LS29 ls29, LS30 ls30, LS31 ls31, LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS15
    {
        public LS15(LS16 ls16, LS17 ls17, LS18 ls18, LS19 ls19, LS20 ls20, LS21 ls21, LS22 ls22, LS23 ls23, LS24 ls24, LS25 ls25, LS26 ls26, LS27 ls27, LS28 ls28, LS29 ls29, LS30 ls30, LS31 ls31, LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS16
    {
        public LS16(LS17 ls17, LS18 ls18, LS19 ls19, LS20 ls20, LS21 ls21, LS22 ls22, LS23 ls23, LS24 ls24, LS25 ls25, LS26 ls26, LS27 ls27, LS28 ls28, LS29 ls29, LS30 ls30, LS31 ls31, LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS17
    {
        public LS17(LS18 ls18, LS19 ls19, LS20 ls20, LS21 ls21, LS22 ls22, LS23 ls23, LS24 ls24, LS25 ls25, LS26 ls26, LS27 ls27, LS28 ls28, LS29 ls29, LS30 ls30, LS31 ls31, LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS18
    {
        public LS18(LS19 ls19, LS20 ls20, LS21 ls21, LS22 ls22, LS23 ls23, LS24 ls24, LS25 ls25, LS26 ls26, LS27 ls27, LS28 ls28, LS29 ls29, LS30 ls30, LS31 ls31, LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS19
    {
        public LS19(LS20 ls20, LS21 ls21, LS22 ls22, LS23 ls23, LS24 ls24, LS25 ls25, LS26 ls26, LS27 ls27, LS28 ls28, LS29 ls29, LS30 ls30, LS31 ls31, LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS20
    {
        public LS20(LS21 ls21, LS22 ls22, LS23 ls23, LS24 ls24, LS25 ls25, LS26 ls26, LS27 ls27, LS28 ls28, LS29 ls29, LS30 ls30, LS31 ls31, LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS21
    {
        public LS21(LS22 ls22, LS23 ls23, LS24 ls24, LS25 ls25, LS26 ls26, LS27 ls27, LS28 ls28, LS29 ls29, LS30 ls30, LS31 ls31, LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS22
    {
        public LS22(LS23 ls23, LS24 ls24, LS25 ls25, LS26 ls26, LS27 ls27, LS28 ls28, LS29 ls29, LS30 ls30, LS31 ls31, LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS23
    {
        public LS23(LS24 ls24, LS25 ls25, LS26 ls26, LS27 ls27, LS28 ls28, LS29 ls29, LS30 ls30, LS31 ls31, LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS24
    {
        public LS24(LS25 ls25, LS26 ls26, LS27 ls27, LS28 ls28, LS29 ls29, LS30 ls30, LS31 ls31, LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS25
    {
        public LS25(LS26 ls26, LS27 ls27, LS28 ls28, LS29 ls29, LS30 ls30, LS31 ls31, LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS26
    {
        public LS26(LS27 ls27, LS28 ls28, LS29 ls29, LS30 ls30, LS31 ls31, LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS27
    {
        public LS27(LS28 ls28, LS29 ls29, LS30 ls30, LS31 ls31, LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS28
    {
        public LS28(LS29 ls29, LS30 ls30, LS31 ls31, LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS29
    {
        public LS29(LS30 ls30, LS31 ls31, LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS30
    {
        public LS30(LS31 ls31, LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS31
    {
        public LS31(LS32 ls32, LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS32
    {
        public LS32(LS33 ls33, LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS33
    {
        public LS33(LS34 ls34, LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS34
    {
        public LS34(LS35 ls35, LS36 ls36)
        {
            
        }
    }

    public class LS35
    {
        public LS35(LS36 ls36)
        {
            
        }
    }

    public class LS36
    {
        public LS36()
        {
            
        }
    }

}
