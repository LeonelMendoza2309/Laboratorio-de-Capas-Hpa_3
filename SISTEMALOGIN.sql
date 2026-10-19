create database if not exists `db_sistema_login`;
use `db_sistema_login`;

create table if not exists `Usuario`(
`ID` int auto_increment primary key,
`dsID` varchar(50) not null,
`dsUsuario` varchar(50) not null,
`dsPassword` varbinary(64) not null,
`dsEstado` char(1) not null default '1',
`dsUsuarioCreacion` varchar(50) default null,
`dtFechaCreacion` datetime default current_timestamp,
`idUsuarioModificacion` varchar(50) default null,
`dtFechaModificacion` datetime default current_timestamp on update current_timestamp
) engine=InnoDB default charset=utf8mb4;


INSERT INTO `Usuario` (`dsId`, `dsUsuario`, `dsPassword`, `dsEstado`, `dsUsuarioCreacion`)
VALUES ('001', 'admin', UNHEX(SHA2('123456', 512)), '1', 'Sistema');

INSERT INTO `Usuario` (`dsId`, `dsUsuario`, `dsPassword`, `dsEstado`, `dsUsuarioCreacion`)
VALUES ('002', 'root', UNHEX(SHA2('251427', 512)), '1', 'Sistema');

drop procedure if exists `sp_ValidarLoginHash`;
DELIMITER //
create procedure `sp_ValidarLoginHash`(
	in _dsUsuario varchar(50),
    in _dsPassword varchar(50)
)
begin
	select
		ID,
        dsID,
        dsUsuario,
        dsPassword,
        dsEstado,
        dsUsuarioCreacion,
        dtFechaCreacion,
        idUsuarioModificacion,
        dtFechaModificacion
from `Usuario`
where dsUsuario = _dsUsuario and dsPassword = unhex(sha2(_dsPassword, 512)) and dsEstado = '1';
end //