namespace DB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Configuration;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public void AdjustConConString(string newConString)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["Model1"].ConnectionString = newConString;
            config.ConnectionStrings.ConnectionStrings["Model1"].ProviderName = "MySql.Data.MySqlClient";
            config.Save(ConfigurationSaveMode.Modified);
        }

        public virtual DbSet<access> accesses { get; set; }
        public virtual DbSet<accountant> accountants { get; set; }
        public virtual DbSet<administrative> administratives { get; set; }
        public virtual DbSet<annual_result> annual_result { get; set; }
        public virtual DbSet<behavioral> behaviorals { get; set; }
        public virtual DbSet<_class> classes { get; set; }
        public virtual DbSet<current_season> current_season { get; set; }
        public virtual DbSet<date> dates { get; set; }
        public virtual DbSet<debtor> debtors { get; set; }
        public virtual DbSet<expens> expenses { get; set; }
        public virtual DbSet<fee_allocation> fee_allocation { get; set; }
        public virtual DbSet<fee_payment> fee_payment { get; set; }
        public virtual DbSet<inventory> inventories { get; set; }
        public virtual DbSet<jss> jsses { get; set; }
        public virtual DbSet<jss_subject_number> jss_subject_number { get; set; }
        public virtual DbSet<mail> mails { get; set; }
        public virtual DbSet<news> news { get; set; }
        public virtual DbSet<pin1> pin1 { get; set; }
        public virtual DbSet<pin2> pin2 { get; set; }
        public virtual DbSet<pin3> pin3 { get; set; }
        public virtual DbSet<portal_request> portal_request { get; set; }
        public virtual DbSet<position> positions { get; set; }
        public virtual DbSet<principal> principals { get; set; }
        public virtual DbSet<results1> results1 { get; set; }
        public virtual DbSet<school_subjects> school_subjects { get; set; }
        public virtual DbSet<session> sessions { get; set; }
        public virtual DbSet<sss> ssses { get; set; }
        public virtual DbSet<sss_subject_number> sss_subject_number { get; set; }
        public virtual DbSet<staff_payroll> staff_payroll { get; set; }
        public virtual DbSet<student_attendance> student_attendance { get; set; }
        public virtual DbSet<student> students { get; set; }
        public virtual DbSet<subject> subjects { get; set; }
        public virtual DbSet<teacher> teachers { get; set; }
        public virtual DbSet<teachers_classes> teachers_classes { get; set; }
        public virtual DbSet<unused_pins> unused_pins { get; set; }
        public virtual DbSet<used_pins> used_pins { get; set; }
        public virtual DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<access>()
                .Property(e => e.control_access)
                .IsUnicode(false);

            modelBuilder.Entity<access>()
                .Property(e => e.date_created)
                .IsUnicode(false);

            modelBuilder.Entity<accountant>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<accountant>()
                .Property(e => e.fullname)
                .IsUnicode(false);

            modelBuilder.Entity<accountant>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<accountant>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<accountant>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<accountant>()
                .Property(e => e.lga)
                .IsUnicode(false);

            modelBuilder.Entity<accountant>()
                .Property(e => e.nationality)
                .IsUnicode(false);

            modelBuilder.Entity<accountant>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<accountant>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<accountant>()
                .Property(e => e.date_of_reg)
                .IsUnicode(false);

            modelBuilder.Entity<administrative>()
                .Property(e => e.school_name)
                .IsUnicode(false);

            modelBuilder.Entity<administrative>()
                .Property(e => e.school_motto)
                .IsUnicode(false);

            modelBuilder.Entity<administrative>()
                .Property(e => e.school_logo)
                .IsUnicode(false);

            modelBuilder.Entity<administrative>()
                .Property(e => e.school_stamp)
                .IsUnicode(false);

            modelBuilder.Entity<administrative>()
                .Property(e => e.upload_date)
                .IsUnicode(false);

            modelBuilder.Entity<annual_result>()
                .Property(e => e._class)
                .IsUnicode(false);

            modelBuilder.Entity<annual_result>()
                .Property(e => e.session)
                .IsUnicode(false);

            modelBuilder.Entity<annual_result>()
                .Property(e => e.reg_number)
                .IsUnicode(false);

            modelBuilder.Entity<annual_result>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<annual_result>()
                .Property(e => e.subjects)
                .IsUnicode(false);

            modelBuilder.Entity<behavioral>()
                .Property(e => e.reg_number)
                .IsUnicode(false);

            modelBuilder.Entity<behavioral>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<behavioral>()
                .Property(e => e._class)
                .IsUnicode(false);

            modelBuilder.Entity<behavioral>()
                .Property(e => e.term)
                .IsUnicode(false);

            modelBuilder.Entity<behavioral>()
                .Property(e => e.session)
                .IsUnicode(false);

            modelBuilder.Entity<behavioral>()
                .Property(e => e.hand_writting)
                .IsUnicode(false);

            modelBuilder.Entity<behavioral>()
                .Property(e => e.musical_skills)
                .IsUnicode(false);

            modelBuilder.Entity<behavioral>()
                .Property(e => e.sports)
                .IsUnicode(false);

            modelBuilder.Entity<behavioral>()
                .Property(e => e.attentiveness)
                .IsUnicode(false);

            modelBuilder.Entity<behavioral>()
                .Property(e => e.attitude_to_work)
                .IsUnicode(false);

            modelBuilder.Entity<behavioral>()
                .Property(e => e.health)
                .IsUnicode(false);

            modelBuilder.Entity<behavioral>()
                .Property(e => e.politeness)
                .IsUnicode(false);

            modelBuilder.Entity<behavioral>()
                .Property(e => e.date)
                .IsUnicode(false);

            modelBuilder.Entity<_class>()
                .Property(e => e.classes)
                .IsUnicode(false);

            modelBuilder.Entity<_class>()
                .Property(e => e.date_added)
                .IsUnicode(false);

            modelBuilder.Entity<current_season>()
                .Property(e => e.current_session)
                .IsUnicode(false);

            modelBuilder.Entity<current_season>()
                .Property(e => e.current_term)
                .IsUnicode(false);

            modelBuilder.Entity<current_season>()
                .Property(e => e.date_declared)
                .IsUnicode(false);

            modelBuilder.Entity<date>()
                .Property(e => e.end_of_term)
                .IsUnicode(false);

            modelBuilder.Entity<date>()
                .Property(e => e.next_term_begins)
                .IsUnicode(false);

            modelBuilder.Entity<date>()
                .Property(e => e.date_declared)
                .IsUnicode(false);

            modelBuilder.Entity<debtor>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<debtor>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<debtor>()
                .Property(e => e.deadline)
                .IsUnicode(false);

            modelBuilder.Entity<debtor>()
                .Property(e => e.date)
                .IsUnicode(false);

            modelBuilder.Entity<expens>()
                .Property(e => e.paid_to)
                .IsUnicode(false);

            modelBuilder.Entity<expens>()
                .Property(e => e.paid_for)
                .IsUnicode(false);

            modelBuilder.Entity<expens>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<expens>()
                .Property(e => e.date)
                .IsUnicode(false);

            modelBuilder.Entity<fee_allocation>()
                .Property(e => e.allocate_class)
                .IsUnicode(false);

            modelBuilder.Entity<fee_allocation>()
                .Property(e => e.student_type)
                .IsUnicode(false);

            modelBuilder.Entity<fee_allocation>()
                .Property(e => e.date_allocated)
                .IsUnicode(false);

            modelBuilder.Entity<fee_payment>()
                .Property(e => e.reg_number)
                .IsUnicode(false);

            modelBuilder.Entity<fee_payment>()
                .Property(e => e.student_name)
                .IsUnicode(false);

            modelBuilder.Entity<fee_payment>()
                .Property(e => e.student_class)
                .IsUnicode(false);

            modelBuilder.Entity<fee_payment>()
                .Property(e => e.student_type)
                .IsUnicode(false);

            modelBuilder.Entity<fee_payment>()
                .Property(e => e.fee_term)
                .IsUnicode(false);

            modelBuilder.Entity<fee_payment>()
                .Property(e => e.fee_session)
                .IsUnicode(false);

            modelBuilder.Entity<fee_payment>()
                .Property(e => e.teller_no)
                .IsUnicode(false);

            modelBuilder.Entity<fee_payment>()
                .Property(e => e.payment_status)
                .IsUnicode(false);

            modelBuilder.Entity<fee_payment>()
                .Property(e => e.date_of_upload)
                .IsUnicode(false);

            modelBuilder.Entity<inventory>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<inventory>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<inventory>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<inventory>()
                .Property(e => e.date)
                .IsUnicode(false);

            modelBuilder.Entity<jss>()
                .Property(e => e.jss_subjects)
                .IsUnicode(false);

            modelBuilder.Entity<jss>()
                .Property(e => e.upload_date)
                .IsUnicode(false);

            modelBuilder.Entity<jss_subject_number>()
                .Property(e => e.declared_date)
                .IsUnicode(false);

            modelBuilder.Entity<mail>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<mail>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<mail>()
                .Property(e => e.message)
                .IsUnicode(false);

            modelBuilder.Entity<mail>()
                .Property(e => e.mail_date)
                .IsUnicode(false);

            modelBuilder.Entity<news>()
                .Property(e => e.header)
                .IsUnicode(false);

            modelBuilder.Entity<news>()
                .Property(e => e.body)
                .IsUnicode(false);

            modelBuilder.Entity<news>()
                .Property(e => e.news_date)
                .IsUnicode(false);

            modelBuilder.Entity<pin1>()
                .Property(e => e.term)
                .IsUnicode(false);

            modelBuilder.Entity<pin1>()
                .Property(e => e.first_term_pin)
                .IsUnicode(false);

            modelBuilder.Entity<pin1>()
                .Property(e => e.serial_number)
                .IsUnicode(false);

            modelBuilder.Entity<pin1>()
                .Property(e => e.upload_date)
                .IsUnicode(false);

            modelBuilder.Entity<pin2>()
                .Property(e => e.term)
                .IsUnicode(false);

            modelBuilder.Entity<pin2>()
                .Property(e => e.second_term_pin)
                .IsUnicode(false);

            modelBuilder.Entity<pin2>()
                .Property(e => e.serial_number)
                .IsUnicode(false);

            modelBuilder.Entity<pin2>()
                .Property(e => e.upload_date)
                .IsUnicode(false);

            modelBuilder.Entity<pin3>()
                .Property(e => e.term)
                .IsUnicode(false);

            modelBuilder.Entity<pin3>()
                .Property(e => e.third_term_pin)
                .IsUnicode(false);

            modelBuilder.Entity<pin3>()
                .Property(e => e.serial_number)
                .IsUnicode(false);

            modelBuilder.Entity<pin3>()
                .Property(e => e.upload_date)
                .IsUnicode(false);

            modelBuilder.Entity<portal_request>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<portal_request>()
                .Property(e => e.school_name)
                .IsUnicode(false);

            modelBuilder.Entity<portal_request>()
                .Property(e => e.position_held)
                .IsUnicode(false);

            modelBuilder.Entity<portal_request>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<portal_request>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<portal_request>()
                .Property(e => e.message)
                .IsUnicode(false);

            modelBuilder.Entity<portal_request>()
                .Property(e => e.request_date)
                .IsUnicode(false);

            modelBuilder.Entity<position>()
                .Property(e => e.reg_number)
                .IsUnicode(false);

            modelBuilder.Entity<position>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<position>()
                .Property(e => e._class)
                .IsUnicode(false);

            modelBuilder.Entity<position>()
                .Property(e => e.term)
                .IsUnicode(false);

            modelBuilder.Entity<position>()
                .Property(e => e.session)
                .IsUnicode(false);

            modelBuilder.Entity<position>()
                .Property(e => e.upload_date)
                .IsUnicode(false);

            modelBuilder.Entity<principal>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<principal>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<principal>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<principal>()
                .Property(e => e.lastname)
                .IsUnicode(false);

            modelBuilder.Entity<principal>()
                .Property(e => e.position)
                .IsUnicode(false);

            modelBuilder.Entity<principal>()
                .Property(e => e.sex)
                .IsUnicode(false);

            modelBuilder.Entity<principal>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<principal>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<principal>()
                .Property(e => e.next_of_kin)
                .IsUnicode(false);

            modelBuilder.Entity<principal>()
                .Property(e => e.next_of_kin_relationship)
                .IsUnicode(false);

            modelBuilder.Entity<principal>()
                .Property(e => e.next_of_kin_phone)
                .IsUnicode(false);

            modelBuilder.Entity<principal>()
                .Property(e => e.date_registered)
                .IsUnicode(false);

            modelBuilder.Entity<results1>()
                .Property(e => e._class)
                .IsUnicode(false);

            modelBuilder.Entity<results1>()
                .Property(e => e.term)
                .IsUnicode(false);

            modelBuilder.Entity<results1>()
                .Property(e => e.session)
                .IsUnicode(false);

            modelBuilder.Entity<results1>()
                .Property(e => e.reg_number)
                .IsUnicode(false);

            modelBuilder.Entity<results1>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<results1>()
                .Property(e => e.subjects)
                .IsUnicode(false);

            modelBuilder.Entity<results1>()
                .Property(e => e.date_of_upload)
                .IsUnicode(false);

            modelBuilder.Entity<school_subjects>()
                .Property(e => e.subjects)
                .IsUnicode(false);

            modelBuilder.Entity<school_subjects>()
                .Property(e => e.date_saved)
                .IsUnicode(false);

            modelBuilder.Entity<session>()
                .Property(e => e.sessions)
                .IsUnicode(false);

            modelBuilder.Entity<session>()
                .Property(e => e.date_added)
                .IsUnicode(false);

            modelBuilder.Entity<sss>()
                .Property(e => e.sss_subjects)
                .IsUnicode(false);

            modelBuilder.Entity<sss>()
                .Property(e => e.upload_date)
                .IsUnicode(false);

            modelBuilder.Entity<sss_subject_number>()
                .Property(e => e.declared_date)
                .IsUnicode(false);

            modelBuilder.Entity<staff_payroll>()
                .Property(e => e.staff_name)
                .IsUnicode(false);

            modelBuilder.Entity<staff_payroll>()
                .Property(e => e.debit_reason)
                .IsUnicode(false);

            modelBuilder.Entity<staff_payroll>()
                .Property(e => e.bonus_reason)
                .IsUnicode(false);

            modelBuilder.Entity<staff_payroll>()
                .Property(e => e.date)
                .IsUnicode(false);

            modelBuilder.Entity<student_attendance>()
                .Property(e => e.reg_number)
                .IsUnicode(false);

            modelBuilder.Entity<student_attendance>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<student_attendance>()
                .Property(e => e.date)
                .IsUnicode(false);

            modelBuilder.Entity<student_attendance>()
                .Property(e => e.term)
                .IsUnicode(false);

            modelBuilder.Entity<student_attendance>()
                .Property(e => e.session)
                .IsUnicode(false);

            modelBuilder.Entity<student_attendance>()
                .Property(e => e._class)
                .IsUnicode(false);

            modelBuilder.Entity<student_attendance>()
                .Property(e => e.roll_call)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.gender)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.lastname)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.othername)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.dob)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.mob)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.yob)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.contact_phone)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.nearest_contact1)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.nearest_contact2)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.nearest_contact3)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.health_conditions)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.father_name)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.father_occupation)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.father_phone)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.mother_name)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.mother_occupation)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.mother_phone)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.lga)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.nationality)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.sponsor_name)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.sponsor_phone)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.sponsor_address)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.sponsor_occupation)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.relationship)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.previous_school)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.last_class_passed)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e._class)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.reg_number)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.gen_password)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.passport)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.date_of_reg)
                .IsUnicode(false);

            modelBuilder.Entity<subject>()
                .Property(e => e.reg_number)
                .IsUnicode(false);

            modelBuilder.Entity<subject>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<subject>()
                .Property(e => e._class)
                .IsUnicode(false);

            modelBuilder.Entity<subject>()
                .Property(e => e.subjects)
                .IsUnicode(false);

            modelBuilder.Entity<subject>()
                .Property(e => e.term)
                .IsUnicode(false);

            modelBuilder.Entity<subject>()
                .Property(e => e.session)
                .IsUnicode(false);

            modelBuilder.Entity<subject>()
                .Property(e => e.registration_date)
                .IsUnicode(false);

            modelBuilder.Entity<teacher>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<teacher>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<teacher>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<teacher>()
                .Property(e => e.lastname)
                .IsUnicode(false);

            modelBuilder.Entity<teacher>()
                .Property(e => e.employment_date)
                .IsUnicode(false);

            modelBuilder.Entity<teacher>()
                .Property(e => e.teacher_position)
                .IsUnicode(false);

            modelBuilder.Entity<teacher>()
                .Property(e => e.subject_to_teach)
                .IsUnicode(false);

            modelBuilder.Entity<teacher>()
                .Property(e => e.lga)
                .IsUnicode(false);

            modelBuilder.Entity<teacher>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<teacher>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<teacher>()
                .Property(e => e.sex)
                .IsUnicode(false);

            modelBuilder.Entity<teacher>()
                .Property(e => e.dob)
                .IsUnicode(false);

            modelBuilder.Entity<teacher>()
                .Property(e => e.mob)
                .IsUnicode(false);

            modelBuilder.Entity<teacher>()
                .Property(e => e.yob)
                .IsUnicode(false);

            modelBuilder.Entity<teacher>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<teacher>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<teacher>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<teacher>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<teacher>()
                .Property(e => e.date_registered)
                .IsUnicode(false);

            modelBuilder.Entity<teachers_classes>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<teachers_classes>()
                .Property(e => e.subject)
                .IsUnicode(false);

            modelBuilder.Entity<teachers_classes>()
                .Property(e => e._class)
                .IsUnicode(false);

            modelBuilder.Entity<teachers_classes>()
                .Property(e => e.term)
                .IsUnicode(false);

            modelBuilder.Entity<unused_pins>()
                .Property(e => e.term)
                .IsUnicode(false);

            modelBuilder.Entity<unused_pins>()
                .Property(e => e.unused_pins1)
                .IsUnicode(false);

            modelBuilder.Entity<unused_pins>()
                .Property(e => e.serial_number)
                .IsUnicode(false);

            modelBuilder.Entity<unused_pins>()
                .Property(e => e.upload_date)
                .IsUnicode(false);

            modelBuilder.Entity<used_pins>()
                .Property(e => e.used_pins1)
                .IsUnicode(false);

            modelBuilder.Entity<used_pins>()
                .Property(e => e.user_reg_number)
                .IsUnicode(false);

            modelBuilder.Entity<used_pins>()
                .Property(e => e.user_class)
                .IsUnicode(false);

            modelBuilder.Entity<used_pins>()
                .Property(e => e.used_term)
                .IsUnicode(false);

            modelBuilder.Entity<used_pins>()
                .Property(e => e.used_session)
                .IsUnicode(false);

            modelBuilder.Entity<used_pins>()
                .Property(e => e.date_used)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.fullname)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.lga)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.nationality)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.date_of_reg)
                .IsUnicode(false);
        }
    }
}
