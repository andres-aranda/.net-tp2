USE [tp2_net]
GO
DELETE FROM [dbo].[alumnos_inscripciones]
GO
DELETE FROM [dbo].[modulos_usuarios]
GO
DELETE FROM [dbo].[usuarios]
GO
DELETE FROM [dbo].[modulos]
GO
DELETE FROM [dbo].[docentes_cursos]
GO
DELETE FROM [dbo].[personas]
GO
DELETE FROM [dbo].[cursos]
GO
DELETE FROM [dbo].[materias]
GO
DELETE FROM [dbo].[comisiones]
GO
DELETE FROM [dbo].[planes]
GO
DELETE FROM [dbo].[especialidades]
GO
SET IDENTITY_INSERT [dbo].[especialidades] ON 

INSERT [dbo].[especialidades] ([id_especialidad], [desc_especialidad]) VALUES (1, N'Ingeniería en Sistemas de Información')
INSERT [dbo].[especialidades] ([id_especialidad], [desc_especialidad]) VALUES (2, N'Ingeniería Mecánica')
INSERT [dbo].[especialidades] ([id_especialidad], [desc_especialidad]) VALUES (3, N'Ingeniería Química')
INSERT [dbo].[especialidades] ([id_especialidad], [desc_especialidad]) VALUES (4, N'Ingeniería Electrónika')
SET IDENTITY_INSERT [dbo].[especialidades] OFF
GO
SET IDENTITY_INSERT [dbo].[planes] ON 

INSERT [dbo].[planes] ([id_plan], [desc_plan], [id_especialidad]) VALUES (1, N'Plan ''95', 1)
INSERT [dbo].[planes] ([id_plan], [desc_plan], [id_especialidad]) VALUES (2, N'Plan 2008x', 1)
INSERT [dbo].[planes] ([id_plan], [desc_plan], [id_especialidad]) VALUES (3, N'Plan ''89', 2)
INSERT [dbo].[planes] ([id_plan], [desc_plan], [id_especialidad]) VALUES (4, N'Plan 2002', 2)
INSERT [dbo].[planes] ([id_plan], [desc_plan], [id_especialidad]) VALUES (5, N'Plan ''72', 3)
INSERT [dbo].[planes] ([id_plan], [desc_plan], [id_especialidad]) VALUES (6, N'Plan 2005', 3)
INSERT [dbo].[planes] ([id_plan], [desc_plan], [id_especialidad]) VALUES (7, N'Plan ''78', 4)
INSERT [dbo].[planes] ([id_plan], [desc_plan], [id_especialidad]) VALUES (8, N'Plan ''95', 4)
INSERT [dbo].[planes] ([id_plan], [desc_plan], [id_especialidad]) VALUES (9, N'Plan 2007', 4)
SET IDENTITY_INSERT [dbo].[planes] OFF
GO
SET IDENTITY_INSERT [dbo].[comisiones] ON 

INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (1, N'1-ISI', 1, 1)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (2, N'2-ISI', 2, 1)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (3, N'3-ISI', 3, 1)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (4, N'4-ISI', 4, 1)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (5, N'1-ISI', 1, 2)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (6, N'2-ISI', 2, 2)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (7, N'3-ISI', 3, 2)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (8, N'4-ISI', 4, 2)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (9, N'1-M', 1, 3)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (10, N'2-M', 2, 3)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (11, N'3-M', 3, 3)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (12, N'4-M', 4, 3)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (13, N'1-M', 1, 4)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (14, N'2-M', 2, 4)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (15, N'3-M', 3, 4)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (16, N'4-M', 4, 4)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (17, N'1-Q', 1, 5)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (18, N'2-Q', 2, 5)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (19, N'3-Q', 3, 5)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (20, N'4-Q', 4, 5)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (21, N'1-Q', 1, 6)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (22, N'2-Q', 2, 6)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (23, N'3-Q', 3, 6)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (24, N'4-Q', 4, 6)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (25, N'1-E', 1, 7)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (26, N'2-E', 2, 7)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (27, N'3-E', 3, 7)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (28, N'4-E', 4, 7)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (29, N'1-E', 1, 8)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (30, N'2-E', 2, 8)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (31, N'3-E', 3, 8)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (32, N'4-E', 4, 9)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (33, N'1-E', 1, 9)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (34, N'2-E', 2, 9)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (35, N'3-E', 3, 9)
INSERT [dbo].[comisiones] ([id_comision], [desc_comision], [anio_especialidad], [id_plan]) VALUES (36, N'4-E', 4, 9)
SET IDENTITY_INSERT [dbo].[comisiones] OFF
GO
SET IDENTITY_INSERT [dbo].[materias] ON 

INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (68, N'Análisis Matemático 1', 4, 256, 1)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (69, N'Análisis Matemático 23', 8, 322, 1)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (71, N'Física 11', 4, 256, 1)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (72, N'Física 2', 5, 320, 1)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (74, N'Álgebra y Geometría 1', 4, 256, 1)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (75, N'Álgebra y Geometría 2', 5, 320, 1)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (76, N'Programación 1 ', 5, 320, 1)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (77, N'Programación 2', 6, 384, 1)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (78, N'Programación 3', 7, 448, 1)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (79, N'Análisis Matemático 1', 4, 256, 2)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (80, N'Análisis Matemático 2', 5, 320, 2)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (82, N'Física 1', 4, 256, 2)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (83, N'Física 2', 5, 320, 2)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (84, N'Física 3', 6, 384, 2)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (85, N'Álgebra y Geometría 1', 4, 256, 2)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (86, N'Álgebra y Geometría 2', 5, 320, 2)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (87, N'Programación 1 ', 5, 320, 2)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (88, N'Programación 2', 6, 384, 2)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (89, N'Programación 3', 7, 448, 2)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (90, N'Análisis Matemático 1', 4, 256, 3)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (91, N'Análisis Matemático 2', 5, 320, 3)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (92, N'Análisis Matemático 3', 6, 384, 3)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (93, N'Física 1', 4, 256, 3)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (94, N'Física 2', 5, 320, 3)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (95, N'Física 3', 6, 384, 3)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (96, N'Álgebra y Geometría 1', 4, 256, 3)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (97, N'Álgebra y Geometría 2', 5, 320, 3)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (98, N'Programación 1 ', 5, 320, 3)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (99, N'Programación 2', 6, 384, 3)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (100, N'Programación 3', 7, 448, 3)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (101, N'Análisis Matemático 1', 4, 256, 4)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (102, N'Análisis Matemático 2', 5, 320, 4)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (103, N'Análisis Matemático 3', 6, 384, 4)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (104, N'Física 1', 4, 256, 4)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (105, N'Física 2', 5, 320, 4)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (106, N'Física 3', 6, 384, 4)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (107, N'Álgebra y Geometría 1', 4, 256, 4)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (108, N'Álgebra y Geometría 2', 5, 320, 4)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (109, N'Programación 1 ', 5, 320, 4)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (110, N'Programación 2', 6, 384, 4)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (111, N'Programación 3', 7, 448, 4)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (112, N'Análisis Matemático 1', 4, 256, 5)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (113, N'Análisis Matemático 2', 5, 320, 5)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (114, N'Análisis Matemático 3', 6, 384, 5)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (115, N'Física 1', 4, 256, 5)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (116, N'Física 2', 5, 320, 5)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (117, N'Física 3', 6, 384, 5)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (118, N'Álgebra y Geometría 1', 4, 256, 5)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (119, N'Álgebra y Geometría 2', 5, 320, 5)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (120, N'Programación 1 ', 5, 320, 5)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (121, N'Programación 2', 6, 384, 5)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (122, N'Programación 3', 7, 448, 5)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (123, N'Análisis Matemático 1', 4, 256, 6)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (124, N'Análisis Matemático 2', 5, 320, 6)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (125, N'Análisis Matemático 3', 6, 384, 6)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (126, N'Física 1', 4, 256, 6)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (127, N'Física 2', 5, 320, 6)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (128, N'Física 3', 6, 384, 6)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (129, N'Álgebra y Geometría 1', 4, 256, 6)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (130, N'Álgebra y Geometría 2', 5, 320, 6)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (131, N'Programación 1 ', 5, 320, 6)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (132, N'Programación 2', 6, 384, 6)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (133, N'Programación 3', 7, 448, 6)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (134, N'Análisis Matemático 1', 4, 256, 7)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (135, N'Análisis Matemático 2', 5, 320, 7)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (136, N'Análisis Matemático 3', 6, 384, 7)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (137, N'Física 1', 4, 256, 7)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (138, N'Física 2', 5, 320, 7)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (139, N'Física 3', 6, 384, 7)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (140, N'Álgebra y Geometría 1', 4, 256, 7)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (141, N'Álgebra y Geometría 2', 5, 320, 7)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (142, N'Programación 1 ', 5, 320, 7)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (143, N'Programación 2', 6, 384, 7)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (144, N'Programación 3', 7, 448, 7)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (145, N'Análisis Matemático 1', 4, 256, 8)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (146, N'Análisis Matemático 2', 5, 320, 8)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (147, N'Análisis Matemático 3', 6, 384, 8)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (148, N'Física 1', 4, 256, 8)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (149, N'Física 2', 5, 320, 8)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (150, N'Física 3', 6, 384, 8)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (151, N'Álgebra y Geometría 1', 4, 256, 8)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (152, N'Álgebra y Geometría 2', 5, 320, 8)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (153, N'Programación 1 ', 5, 320, 8)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (154, N'Programación 2', 6, 384, 8)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (155, N'Programación 3', 7, 448, 8)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (156, N'Análisis Matemático 1', 4, 256, 9)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (157, N'Análisis Matemático 2', 5, 320, 9)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (158, N'Análisis Matemático 3', 6, 384, 9)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (159, N'Física 1', 4, 256, 9)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (160, N'Física 2', 5, 320, 9)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (161, N'Física 3', 6, 384, 9)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (162, N'Álgebra y Geometría 1', 4, 256, 9)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (163, N'Álgebra y Geometría 2', 5, 320, 9)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (164, N'Programación >', 5, 320, 1)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (165, N'Programación 2', 6, 384, 9)
INSERT [dbo].[materias] ([id_materia], [desc_materia], [hs_semanales], [hs_totales], [id_plan]) VALUES (166, N'Programación 3', 7, 448, 9)
SET IDENTITY_INSERT [dbo].[materias] OFF
GO
SET IDENTITY_INSERT [dbo].[cursos] ON 

INSERT [dbo].[cursos] ([id_curso], [id_materia], [id_comision], [anio_calendario], [cupo]) VALUES (4, 82, 1, 2020, 30)
INSERT [dbo].[cursos] ([id_curso], [id_materia], [id_comision], [anio_calendario], [cupo]) VALUES (6, 69, 3, 2020, 30)
INSERT [dbo].[cursos] ([id_curso], [id_materia], [id_comision], [anio_calendario], [cupo]) VALUES (9, 164, 2, 2020, 30)
INSERT [dbo].[cursos] ([id_curso], [id_materia], [id_comision], [anio_calendario], [cupo]) VALUES (10, 69, 1, 2020, 30)
INSERT [dbo].[cursos] ([id_curso], [id_materia], [id_comision], [anio_calendario], [cupo]) VALUES (11, 69, 2, 2020, 30)
INSERT [dbo].[cursos] ([id_curso], [id_materia], [id_comision], [anio_calendario], [cupo]) VALUES (13, 68, 3, 2020, 30)
INSERT [dbo].[cursos] ([id_curso], [id_materia], [id_comision], [anio_calendario], [cupo]) VALUES (14, 68, 4, 2020, 12)
INSERT [dbo].[cursos] ([id_curso], [id_materia], [id_comision], [anio_calendario], [cupo]) VALUES (16, 87, 2, 2020, 23)
INSERT [dbo].[cursos] ([id_curso], [id_materia], [id_comision], [anio_calendario], [cupo]) VALUES (17, 79, 1, 2020, 5)
INSERT [dbo].[cursos] ([id_curso], [id_materia], [id_comision], [anio_calendario], [cupo]) VALUES (18, 85, 2, 2020, 4)
INSERT [dbo].[cursos] ([id_curso], [id_materia], [id_comision], [anio_calendario], [cupo]) VALUES (19, 87, 2, 2020, 4)
INSERT [dbo].[cursos] ([id_curso], [id_materia], [id_comision], [anio_calendario], [cupo]) VALUES (23, 84, 2, 2020, 50)
SET IDENTITY_INSERT [dbo].[cursos] OFF
GO
SET IDENTITY_INSERT [dbo].[personas] ON 

INSERT [dbo].[personas] ([id_persona], [nombre], [apellido], [direccion], [email], [telefono], [fecha_nac], [legajo], [tipo_persona], [id_plan]) VALUES (2, N'Juanita 2', N'Juan', N'p jerman wallavy 42 sidney', N'rperez@gmail.com', N'08812345', CAST(N'1810-06-01T00:00:00.000' AS DateTime), 1111, 1, 1)
INSERT [dbo].[personas] ([id_persona], [nombre], [apellido], [direccion], [email], [telefono], [fecha_nac], [legajo], [tipo_persona], [id_plan]) VALUES (3, N'Raton', N'Perez', N'la cueva del otoño 123', N'rperez@gmail.com', N'0800raton', CAST(N'1815-04-04T00:00:00.000' AS DateTime), 1112, 1, 2)
INSERT [dbo].[personas] ([id_persona], [nombre], [apellido], [direccion], [email], [telefono], [fecha_nac], [legajo], [tipo_persona], [id_plan]) VALUES (4, N'Marta', N'Zanches', N'el valala', N'rperez@gmail.com', N'0900hacha', CAST(N'1753-05-02T00:00:00.000' AS DateTime), 1113, 1, 2)
INSERT [dbo].[personas] ([id_persona], [nombre], [apellido], [direccion], [email], [telefono], [fecha_nac], [legajo], [tipo_persona], [id_plan]) VALUES (6, N'Darth', N'Vader', N'espacio intergalactico', N'rperez@gmail.com', N'0700space', CAST(N'2000-08-09T00:00:00.000' AS DateTime), 1114, 1, 1)
INSERT [dbo].[personas] ([id_persona], [nombre], [apellido], [direccion], [email], [telefono], [fecha_nac], [legajo], [tipo_persona], [id_plan]) VALUES (7, N'Hermione', N'Granger', N'howarts 1', N'rperez@gmail.com', N'0600magico', CAST(N'1900-08-01T00:00:00.000' AS DateTime), 1115, 1, 4)
INSERT [dbo].[personas] ([id_persona], [nombre], [apellido], [direccion], [email], [telefono], [fecha_nac], [legajo], [tipo_persona], [id_plan]) VALUES (8, N'Han', N'Solo', N'espacio interestelar 2', N'rperez@gmail.com', N'0800starwars', CAST(N'1950-12-02T00:00:00.000' AS DateTime), 1116, 1, 2)
INSERT [dbo].[personas] ([id_persona], [nombre], [apellido], [direccion], [email], [telefono], [fecha_nac], [legajo], [tipo_persona], [id_plan]) VALUES (9, N'Raton', N'Perez', N'b', N'rperez@gmail.com', N'0900bebe', CAST(N'1980-12-05T00:00:00.000' AS DateTime), 1117, 1, 6)
INSERT [dbo].[personas] ([id_persona], [nombre], [apellido], [direccion], [email], [telefono], [fecha_nac], [legajo], [tipo_persona], [id_plan]) VALUES (10, N'dsadsa', N'adsada', N'dasd', N'2@gmail.com', N'22', CAST(N'2020-11-04T00:00:00.000' AS DateTime), 77777, 0, 1)
SET IDENTITY_INSERT [dbo].[personas] OFF
GO
SET IDENTITY_INSERT [dbo].[docentes_cursos] ON 

INSERT [dbo].[docentes_cursos] ([id_dictado], [id_curso], [id_docente], [cargo]) VALUES (1001, 10, 2, 1)
INSERT [dbo].[docentes_cursos] ([id_dictado], [id_curso], [id_docente], [cargo]) VALUES (1004, 14, 2, 1)
INSERT [dbo].[docentes_cursos] ([id_dictado], [id_curso], [id_docente], [cargo]) VALUES (1005, 16, 2, 1)
INSERT [dbo].[docentes_cursos] ([id_dictado], [id_curso], [id_docente], [cargo]) VALUES (1008, 11, 8, 1)
INSERT [dbo].[docentes_cursos] ([id_dictado], [id_curso], [id_docente], [cargo]) VALUES (2004, 17, 8, 1)
INSERT [dbo].[docentes_cursos] ([id_dictado], [id_curso], [id_docente], [cargo]) VALUES (2006, 16, 8, 1)
INSERT [dbo].[docentes_cursos] ([id_dictado], [id_curso], [id_docente], [cargo]) VALUES (2007, 18, 8, 1)
SET IDENTITY_INSERT [dbo].[docentes_cursos] OFF
GO
SET IDENTITY_INSERT [dbo].[modulos] ON 

INSERT [dbo].[modulos] ([id_modulo], [desc_modulo]) VALUES (1, N'Docente')
INSERT [dbo].[modulos] ([id_modulo], [desc_modulo]) VALUES (2, N'Alumno')
INSERT [dbo].[modulos] ([id_modulo], [desc_modulo]) VALUES (3, N'NoDocente')
INSERT [dbo].[modulos] ([id_modulo], [desc_modulo]) VALUES (4, N'Administrador')
SET IDENTITY_INSERT [dbo].[modulos] OFF
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([id_usuario], [nombre_usuario], [clave], [cambia_clave], [id_persona]) VALUES (1, N'a', N'a', NULL, 2)
INSERT [dbo].[usuarios] ([id_usuario], [nombre_usuario], [clave], [cambia_clave], [id_persona]) VALUES (2, N'rperez', N'12345678', NULL, 3)
INSERT [dbo].[usuarios] ([id_usuario], [nombre_usuario], [clave], [cambia_clave], [id_persona]) VALUES (3, N'mzanches', N'12345678', NULL, 4)
INSERT [dbo].[usuarios] ([id_usuario], [nombre_usuario], [clave], [cambia_clave], [id_persona]) VALUES (5, N'dvader', N'12345678', NULL, 6)
INSERT [dbo].[usuarios] ([id_usuario], [nombre_usuario], [clave], [cambia_clave], [id_persona]) VALUES (6, N'hgranger', N'12345678', NULL, 7)
INSERT [dbo].[usuarios] ([id_usuario], [nombre_usuario], [clave], [cambia_clave], [id_persona]) VALUES (7, N'hsolo', N'12345678', NULL, 8)
SET IDENTITY_INSERT [dbo].[usuarios] OFF
GO
SET IDENTITY_INSERT [dbo].[modulos_usuarios] ON 

INSERT [dbo].[modulos_usuarios] ([id_modulo_usuario], [id_modulo], [id_usuario]) VALUES (1023, 1, 1)
INSERT [dbo].[modulos_usuarios] ([id_modulo_usuario], [id_modulo], [id_usuario]) VALUES (1024, 2, 2)
INSERT [dbo].[modulos_usuarios] ([id_modulo_usuario], [id_modulo], [id_usuario]) VALUES (1025, 2, 3)
INSERT [dbo].[modulos_usuarios] ([id_modulo_usuario], [id_modulo], [id_usuario]) VALUES (1026, 4, 5)
INSERT [dbo].[modulos_usuarios] ([id_modulo_usuario], [id_modulo], [id_usuario]) VALUES (1027, 3, 6)
INSERT [dbo].[modulos_usuarios] ([id_modulo_usuario], [id_modulo], [id_usuario]) VALUES (1028, 1, 7)
SET IDENTITY_INSERT [dbo].[modulos_usuarios] OFF
GO
SET IDENTITY_INSERT [dbo].[alumnos_inscripciones] ON 

INSERT [dbo].[alumnos_inscripciones] ([id_inscripcion], [id_alumno], [id_curso], [condicion], [nota]) VALUES (14, 3, 4, N'Cursando', 0)
INSERT [dbo].[alumnos_inscripciones] ([id_inscripcion], [id_alumno], [id_curso], [condicion], [nota]) VALUES (2012, 8, 18, N'Aprobada', 8)
INSERT [dbo].[alumnos_inscripciones] ([id_inscripcion], [id_alumno], [id_curso], [condicion], [nota]) VALUES (2013, 3, 17, N'Cursando', 10)
INSERT [dbo].[alumnos_inscripciones] ([id_inscripcion], [id_alumno], [id_curso], [condicion], [nota]) VALUES (2014, 3, 20, N'Cursando', 0)
INSERT [dbo].[alumnos_inscripciones] ([id_inscripcion], [id_alumno], [id_curso], [condicion], [nota]) VALUES (2015, 3, 23, N'Cursando', 0)
INSERT [dbo].[alumnos_inscripciones] ([id_inscripcion], [id_alumno], [id_curso], [condicion], [nota]) VALUES (2016, 4, 4, N'Cursando', 0)
INSERT [dbo].[alumnos_inscripciones] ([id_inscripcion], [id_alumno], [id_curso], [condicion], [nota]) VALUES (2017, 3, 18, N'Cursando', 2)
SET IDENTITY_INSERT [dbo].[alumnos_inscripciones] OFF
GO
