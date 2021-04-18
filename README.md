# 
 Bu proje nitelikli yazılım geliştirici kampı eğitimi tekrarı niteliğinde hazırlanmıştır.
 Proje Aspect'ler (Validation[FluentValidation], Transaction, Cache, Performance) barındırmaktadır.
 JWT entegre edilmiştir ve Autofac desteği kullanılmıştır.
 ReCap Project : 
Araba Kiralama Sistemi Rent A Car
Entities, DataAccess, Business,ConsoleUI, Core ve WebAPI katmanlarından oluşan araba kiralama projesidir. 
Bu projede  katmanlı mimari yapısı ve SOLID prensiplerine dikkat edilerek yazılmıştır. JWT entegrasyonu; Transaction, Cache,  Validation ve Performance aspect'lerinin implementasyonu gerçekleştirilmiştir. Validation için FluentValidation desteği, IoC  için ise Autofac desteği eklenmiştir.

Katmanlar
🗃 Entities Layer 
  📂 Concrete 
📃 Brand.cs 
📃 Car.cs 
📃 CarImage.cs 
📃 Color.cs 
📃 Customer.cs
 📃 Rental.cs

📂 DTOs
     📃 CarDetailDto.cs
     📃 RentalDetailDto.cs
     📃 UserForLoginDto.cs
     📃 UserForRegisterDto.cs

🗃 Business Layer 
    📂 Abstract 
     📃 IAuthService.cs 
     📃 IBrandService.cs
     📃 ICarImageService.cs 
     📃 ICarService.cs 
     📃 IColorService.cs 
     📃 ICustomerService.cs 
     📃 IRentalService.cs
     📃 IUserService.cs

📂 BusinessAspect
    📂 Autofac
         📃 SecuredOperation.cs

📂 Concrete
     📃 AuthManager.cs
     📃 BrandManager.cs
     📃 CarImageManager.cs
     📃 CarManager.cs
     📃 ColorManager.cs
     📃 CustomerManager.cs
     📃 RentalManager.cs
     📃 UserManager.cs

 📂 Constants
     📃 Messages.cs

 📂 DependencyResolvers
     📂 Autofac
         📃 AutofacBusinessModule.cs

 📂 ValidationRules
     📂 FluentValidation
         📃 BrandValidator.cs
         📃 CarValidator.cs
         📃 ColorValidator.cs
         📃 CustomerValidator.cs
         📃 RentalValidator.cs
         📃 UserValidator.cs

🗃 Data Access Layer 
   📂 Abstract 
      📃 IBrandDal.cs 
      📃 ICarImageDal.cs
      📃 ICarDal.cs
      📃 IColorDal.cs 
      📃 ICustomerDal.cs 
      📃 IRentalDal.cs 
      📃 IUserDal.cs

 📂 Concrete
     📂 EntityFramework
         📂 Context
             📃 RentACarContext.cs
         📂 Repository
             📃 EfBrandDal.cs
             📃 EfCarImageDal.cs
             📃 EfCarDal.cs
             📃 EfColorDal.cs
             📃 EfCustomerDal.cs
             📃 EfRentalDal.cs
             📃 EfUserDal.cs

🗃 Core Layer 
   📂 Aspect 
      📂 Autofac 
         📂 Caching 
             📃 CacheAspect.cs 
             📃 CacheRemoveAspect.cs 
    📂 Expection
             📃 ExceptionLogAspect.cs 
    📂 Logging 
             📃 LogAspect.cs 
     📂 Performance 
             📃 PerformanceAspect.cs 
     📂 Transaction
             📃 TransactionScopeAscpect.cs 
     📂 Validation
             📃 ValidationAspect.cs

     📂 CrossCuttingConcerns
         📂 Caching
            📃 ICacheManager.cs
        📂 Microsoft
            📃 MemoryCacheManager.cs
        📂 Logging
            📃 LogDetail.cs
            📃 LogDetailWithException.cs
            📃 LogParameter.cs
        📂 Log4Net
            📃 LoggerServiceBase.cs
            📃 SerializableLogEvent.cs
        📂 Layouts
            📃 JsonLayout.cs
        📂 Loggers
            📃 FileLogger.cs
    📂 Validation
            📃 ValidationTool.cs

    📂 DataAccess
            📃 IEntityRepository.cs
    📂 EntityFramework
            📃 EfEntityRepositoryBase.cs

     📂 DependencyResolvers
            📃 CoreModule.cs

     📂 Entities
            📃 IDto.cs
            📃 IEntity.cs
     📂 Concrete
            📃 OperationClaim.cs
            📃 User.cs
            📃 UserOperationClaim.cs

      📂 Extensions
            📃 ClaimExtensions.cs
            📃 ClaimsPrincipalExtensions.cs
            📃 ServiceCollectionExtensions.cs

     📂 Utilities
        📂 Business
           📃 BusinessRules.cs
        📂 Helpers
           📃 FileHelper.cs
        📂 Interceptors
           📃 AspectInterceptorSelector.cs
           📃 MethodInterception.cs
           📃 MethodInterceptionBaseAttribute.cs
        📂 IoC
           📃 ICoreModule.cs
           📃 ServiceTool.cs
        📂 Messages
           📃 AspectMessages.cs
        📂 Results
           📃 IDataResult.cs
           📃 DataResult.cs
           📃 SuccessDataResult.cs
           📃 ErrorDataResult.cs
           📃 IResult.cs
           📃 Result.cs
           📃 SuccessResult.cs
           📃 ErrorResult.cs
        📂 Security
            📂 Encryption
           📃 SecurityKeyHelper.cs
           📃 SigningCredentialsHelper.cs
            📂 Hashing
           📃 HashingHelper.cs
            📂 JWT
           📃 AccessToken.cs
           📃 ITokenHelper.cs
           📃 JwtHelper.cs
           📃 TokenOptions.cs
       🗃 Presentation Layer 
           📃 Program.cs

        🗃 WebAPI Layer 
           📃 Startup.cs 
       📂 Controllers
           📃 AuthController.cs 
           📃 BrandsController.cs 
           📃 CarImagesController.cs 
           📃 CarsController.cs  
           📃 ColorsController.cs 
           📃 CustomersController.cs 
           📃 RentalsController.cs 
           📃 UsersController.cs

         SQL Query 
           📃CarDataSQLQuery.sql
