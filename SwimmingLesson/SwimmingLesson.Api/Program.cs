using SwimmingLesson.Core.InterfaceRepository;
using SwimmingLesson.Core.InterfaceService;
using SwimmingLesson.Data;
using SwimmingLesson.Data.Repository;
using SwimmingLesson.Service.Service;
using SwimmingLesson.Service.Services;
using SwimmingLessons.Entities;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<ICourseRepository, CourseRepository>();
builder.Services.AddScoped(typeof(IRepositoryManager<>), typeof(RepositoryManager<>));

builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions((options) => {
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});

//builder.Services.AddScoped<IRepository<Course>, Repository<Course>>();
//builder.Services.AddScoped<IRepository<Guide>, Repository<Guide>>();
//builder.Services.AddScoped<IRepository<Student>, Repository<Student>>();
//builder.Services.AddScoped<IRepository<Lesson>, Repository<Lesson>>();
//builder.Services.AddScoped<IRepository<Group>, Repository<Group>>();


builder.Services.AddScoped<ICourseService,CourseService>();
builder.Services.AddScoped<IGuideService, GuideService>();
builder.Services.AddScoped<ILessonService, LessonService>();
builder.Services.AddScoped<IStudentService, StudentService>();
//builder.Services.AddScoped<IGroupService, GroupService>();




builder.Services.AddDbContext<DataContext>();
//builder.Services.AddSingleton<DataContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
