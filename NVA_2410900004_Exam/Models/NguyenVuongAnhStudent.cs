using System;
using System.Collections.Generic;

namespace NVA_2410900004_Exam.Models;

public partial class NguyenVuongAnhStudent
{
    public int Id { get; set; }

    public string? NguyenVuongAnhName { get; set; }

    public int? NguyenVuongAnhGender { get; set; }

    public DateOnly? NguyenVuongAnhBirthDay { get; set; }

    public string? NguyenVuongAnhEmail { get; set; }

    public string? NguyenVuongAnhPhone { get; set; }

    public bool? NguyenVuongAnhActive { get; set; }
}
