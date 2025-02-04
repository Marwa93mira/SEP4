﻿using Application.LogicInterfaces;
using Domain.DTOs;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class RoomsController : ControllerBase
{
    private readonly IRoomLogic roomLogic;

    public RoomsController(IRoomLogic roomLogic)
    {
        this.roomLogic = roomLogic;
    }
    
    
    [HttpPost]
    public async Task<ActionResult<Room>> CreateAsync(RoomCreationDto dto)
    {
        try
        {
            Room room = await roomLogic.CreateAsync(dto);
            return Created($"/rooms/{room.Id}", room);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
}